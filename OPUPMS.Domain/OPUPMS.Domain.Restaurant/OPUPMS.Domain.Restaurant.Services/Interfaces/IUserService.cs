﻿using System.Threading.Tasks;
using OPUPMS.Domain.Base.Dtos;
using OPUPMS.Domain.Restaurant.Model.Dtos;
using System.Collections.Generic;
using OPUPMS.Domain.Base.ConvertModels;

namespace OPUPMS.Domain.Restaurant.Services.Interfaces
{
    public interface IUserService
    {
        Task<UserDto> CheckLogin(string userName, string password,int companyId=0);

        UserDto GetUserInfo(VerifyUserDTO verifyUserDTO);

        List<UserDto> GetSales();
        bool UpdateUserPassWord(int userId, string oldPassword, string newPassword);
        UserDto GetUserIdByToken(string token);
    }
}
