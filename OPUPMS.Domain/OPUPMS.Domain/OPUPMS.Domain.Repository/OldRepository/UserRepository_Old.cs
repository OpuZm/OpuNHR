using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Smooth.IoC.UnitOfWork;
using OPUPMS.Infrastructure.Dapper;
using OPUPMS.Domain.Base.Models;
using OPUPMS.Domain.Base.ConvertModels;
using OPUPMS.Domain.Base.Repositories.OldRepositories;
using OPUPMS.Infrastructure.Common;

namespace OPUPMS.Domain.Repository.OldRepository
{
    public class UserRepository_Old : MultiDbRepository<CzdmModel, int>, IUserRepository_Old
    {
        public UserRepository_Old(IMultiDbDbFactory factory) : base(factory)
        {

        }

        protected static readonly string GetByUserNameSql = @"SELECT * FROM SUsers WHERE UserName = @Czdmmc00";
        protected static readonly string GetByUserIdSql = @"SELECT * FROM SUsers WHERE Id = @Id";
        protected static readonly string GetByUserIdListSql = @"SELECT * FROM SUsers WHERE Id IN (@IdList)";
        protected static readonly string GetByUsersSql = @"SELECT * FROM SUsers where UserType & @UserType>0";
        protected static readonly string UpdateUserSql = @"update SUsers set UserPwd=@Password where Id=@Id";
        protected static readonly string GetCompanyUsersSql = @"SELECT s1.* FROM dbo.SUsers s1 LEFT JOIN dbo.SOrganizationUsers s2 ON s1.Id=s2.UserId WHERE s2.CompanyId=@CompanyId";

        public List<UserInfo> GetCompanyUsers(int companyId)
        {
            using (var session = Factory.Create<ISession>())
            {
                var result = session.Query<CzdmModel>(GetCompanyUsersSql, new { CompanyId = companyId });

                var infoList = AutoMapper.Mapper.Map<IEnumerable<CzdmModel>, List<UserInfo>>(result);
                return infoList;
            }
        }

        public virtual UserInfo GetByUserName(string token, string userName,int companyId)
        {
            using(var session = Factory.Create<ISession>())
            {
                var result = session.QueryFirstOrDefault<CzdmModel>(GetByUserNameSql, new CzdmModel { UserName = userName });
                
                return ConvertToInfo(result);
            }
        }

        

        public virtual async Task<UserInfo> GetByUserNameAsync(string token, string userName)
        {
            using (var session = Factory.Create<ISession>())
            {
                var model = await session.QueryFirstOrDefaultAsync<CzdmModel>(GetByUserNameSql, new CzdmModel { UserName = userName });

                return ConvertToInfo(model);
            }
        }

        public virtual UserInfo GetByUserId(int userId)
        {
            using (var session = Factory.Create<ISession>())
            {
                var result = session.QueryFirstOrDefault<CzdmModel>(GetByUserIdSql, new { Id = userId });

                return ConvertToInfo(result);
            }
        }

        public virtual UserInfo GetByUserIdCompany(int userId,int companyId)
        {
            using (var session = Factory.Create<ISession>())
            {
                var result = session.QueryFirstOrDefault<CzdmModel>(GetByUserIdSql, new { Id = userId });

                return ConvertToInfo(result);
            }
        }

        public virtual List<UserInfo> GetByUserIds(List<int> userIds)
        {
            using (var session = Factory.Create<ISession>())
            {
                var result = session.Query<CzdmModel>(GetByUserIdListSql, new { IdList = userIds });

                var infoList = AutoMapper.Mapper.Map<IEnumerable<CzdmModel>, List<UserInfo>>(result);
                return infoList;
            }
        }

        /// <summary>
        /// 转换模型
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        protected UserInfo ConvertToInfo(CzdmModel model)
        {
            if (model == null)
                return null;

            UserInfo user = AutoMapper.Mapper.Map<CzdmModel, UserInfo>(model);
            return user;
        }

        /// <summary>
        /// 自动转换映射
        /// </summary>
        /// <param name="log"></param>
        /// <returns></returns>
        private CzdmModel ConvertToModel(UserInfo user)
        {
            CzdmModel model = AutoMapper.Mapper.Map<UserInfo, CzdmModel>(user);
            return model;
        }

        List<UserInfo> IUserRepository_Old.GetByUsersSql(int userType)
        {
            using (var session = Factory.Create<ISession>())
            {
                var result = session.Query<CzdmModel>(GetByUsersSql, new { UserType = userType });

                var infoList = AutoMapper.Mapper.Map<IEnumerable<CzdmModel>, List<UserInfo>>(result);
                return infoList;
            }
        }

        public bool UpdatePassWord(int id,string passWord)
        {
            using (var session = Factory.Create<ISession>())
            {
                var result = session.Execute(UpdateUserSql, new { Id = id, Password= strToToHexByte(passWord) });
                return result > 0 ? true : false;
            }
        }

        private static byte[] strToToHexByte(string hexString)
        {
            hexString = hexString.Replace(" ", "");
            if ((hexString.Length % 2) != 0)
                hexString += " ";
            byte[] returnBytes = new byte[hexString.Length / 2];
            for (int i = 0; i < returnBytes.Length; i++)
                returnBytes[i] = Convert.ToByte(hexString.Substring(i * 2, 2), 16);
            return returnBytes;
        }
    }
}
