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

namespace OPUPMS.Domain.Restaurant.Repository
{
    public class SCompanyRepository : SqlSugarService, ISCompanyRepository
    {
        public List<SCompanyDTO> GetGroupCompanys(int groupId = 0)
        {
            using (var db=new SqlSugarClient(Connection))
            {
                var sql = db.Queryable<SCompany>();
                if (groupId > 0)
                {
                    sql.Where(p => p.ParentId == groupId);
                }
                sql.Where(p => p.IsDelete == false);
                var res = sql.Select<SCompanyDTO>(p => new SCompanyDTO
                {
                    Name=p.Name,
                    Id=p.Id,
                    FullName=p.FullName
                }).ToList();
                return res;
            }
        }

        public string GetApiStr()
        {
            return ApiConnection;
        }
    }
}
