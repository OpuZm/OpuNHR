using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OPUPMS.Domain.Restaurant.Model;
using OPUPMS.Domain.Restaurant.Model.Dtos;
using OPUPMS.Domain.Restaurant.Repository.IocManagerMoudles;
using SqlSugar;
using AutoMapper;
using OPUPMS.Domain.Base.Dtos;
using OPUPMS.Domain.Base.Models;

namespace OPUPMS.Domain.Restaurant.Repository
{
    public class CompanyUserRepository : SqlSugarService, ICompanyUserRepository
    {
        public UserDto GetCompanyUseById(int userId,int companyId)
        {
            using (var db=new SqlSugarClient(Connection))
            {
                var data = db.Sqlable()
                    .From("SUsers", "s1")
                    .Where($"s1.Id={userId}")
                    .SelectToList<UserDto>("s1.*,Id as UserId,Discount as MinDiscountValue").First();
                if (data != null)
                {
                    var list = db.Queryable<UserRestaurant>().Where(p => p.UserId == userId && p.CompanyId==companyId).ToList();
                    data.ManagerRestaurantList = list.Select(p => p.RestaurantId).ToList();
                }
                return data;
            }
        }

        public List<UserDto> GetCompanyUsers(out int total, CompanyUserSearchDTO req)
        {
            using (var db=new SqlSugarClient(Connection))
            {
                int totalCount = 0;
                string order = string.Empty;
                List<UserDto> list = new List<UserDto>();

                if (!string.IsNullOrEmpty(req.Sort))
                {
                    if (req.Sort.Equals("id", StringComparison.OrdinalIgnoreCase))
                    {
                        order = "s1.Id desc";
                    }
                    else
                    {
                        order = string.Format("{0} {1}", req.Sort, req.Order);
                    }
                }
                var data = db.Sqlable()
                    .From("SUsers", "s1")
                    .Join("SOrganizationUsers", "s2","s1.Id","s2.UserId",JoinType.Left)
                    .Where("ISNULL(s1.IsTechnicalAssistance,0)=0 ");
                if (req.CompanyId > 0)
                {
                    data = data.Where("s2.CompanyId=" + req.CompanyId);
                }
                if (!string.IsNullOrEmpty(req.UserName))
                {
                    data = data.Where($"s1.UserName like '%{req.UserName}%'");
                }
                totalCount = data.Count();
                list = data.SelectToPageList<UserDto>(
                    @"s1.*,s1.Id as UserId",
                    order, (req.offset / req.limit) + 1, req.limit, null);
                total = totalCount;

                var userIds = list.Select(p => p.UserId).ToArray();
                var userRestaurantData = db.Sqlable()
                    .From("UserRestaurant", "s1")
                    .Join("R_Restaurant", "s2", "s1.RestaurantId", "s2.Id", JoinType.Left);
                if (req.CompanyId > 0)
                {
                    userRestaurantData = userRestaurantData.Where("s2.R_Company_Id=" + req.CompanyId);
                }
                var userRestaurant = userRestaurantData.SelectToList<UserRestaurant>("s1.*");
                if (list.Any() && userRestaurant.Any())
                {
                    foreach (var item in list)
                    {
                        item.ManagerRestaurantList = userRestaurant.Where(p => p.UserId == item.UserId).Select(p => p.RestaurantId).ToList();
                    }
                }
                return list;
            }
        }

        public bool UpdateUserManagerRestaurant(UserDto user, List<int> restaurantIds)
        {
            using (var db=new SqlSugarClient(Connection))
            {
                try
                {
                    int companyId = Convert.ToInt32(user.RoleId);
                    db.BeginTran();
                    db.Delete<UserRestaurant>(p => p.UserId == user.UserId && p.CompanyId==companyId);
                    List<UserRestaurant> list = new List<UserRestaurant>();
                    restaurantIds.ForEach(p =>
                    {
                        list.Add(new UserRestaurant()
                        {
                            UserId = user.UserId,
                            RestaurantId = p,
                            CompanyId = companyId
                        });
                    });
                    db.InsertRange(list);

                    db.Update<SUsers>(new { RestaurantAuthority = user.RestaurantAuthority, Discount = user.MinDiscountValue, MaxClearValue=user.MaxClearValue }, p => p.Id == user.UserId);
                    db.CommitTran();
                    return true;
                }
                catch (Exception e)
                {
                    db.RollbackTran();
                    throw e;
                }
                
            }
        }

        public bool UpdateUserRestaurantPermission(UserDto user)
        {
            using (var db=new SqlSugarClient(Connection))
            {
                try
                {
                    db.Update<SUsers>(new { RestaurantAuthority = user.RestaurantAuthority }, p => p.Id == user.UserId);
                    return true;
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
        }
    }
}
