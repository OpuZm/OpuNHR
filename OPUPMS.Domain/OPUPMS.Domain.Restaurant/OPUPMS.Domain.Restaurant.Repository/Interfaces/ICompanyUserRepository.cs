using System.Collections.Generic;
using OPUPMS.Domain.Restaurant.Model.Dtos;
using OPUPMS.Domain.Base.Models;
using OPUPMS.Domain.Base.Dtos;

namespace OPUPMS.Domain.Restaurant.Repository
{
    public interface ICompanyUserRepository
    {
        List<UserDto> GetCompanyUsers(out int total, CompanyUserSearchDTO req);
        UserDto GetCompanyUseById(int userId,int companyId);
        bool UpdateUserManagerRestaurant(UserDto user, List<int> restaurantIds);
        bool UpdateUserRestaurantPermission(UserDto user);
    }
}
