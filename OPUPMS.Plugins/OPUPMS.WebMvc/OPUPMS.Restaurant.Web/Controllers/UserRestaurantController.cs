﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using OPUPMS.Domain.Base;
using OPUPMS.Domain.Restaurant.Model.Dtos;
using OPUPMS.Domain.Restaurant.Repository;
using OPUPMS.Domain.Restaurant.Services.Interfaces;
using OPUPMS.Infrastructure.Common;
using OPUPMS.Infrastructure.Common.Operator;
using OPUPMS.Infrastructure.Common.Security;
using OPUPMS.Restaurant.Web.Models;
using OPUPMS.Web.Framework.Core.Mvc;
using OPUPMS.Domain.Base.Repositories;
using OPUPMS.Domain.Base.Models;
using OPUPMS.Domain.AuthorizeService;
using OPUPMS.Domain.Base.Dtos;


namespace OPUPMS.Restaurant.Web.Controllers
{
    [CustomerAuthorize(Permission.餐饮系统设置)]
    public class UserRestaurantController : AuthorizationController
    {
        private readonly ICompanyUserRepository companyUserRepository;
        private readonly IRestaurantRepository restaurantRepository;

        public UserRestaurantController(ICompanyUserRepository _companyUserRepository,
            IRestaurantRepository _restaurantRepository)
        {
            companyUserRepository = _companyUserRepository;
            restaurantRepository = _restaurantRepository;
        }

        // GET: UserRestaurant
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Edit()
        {
            return View();
        }

        public ActionResult GetCompanyUsers(CompanyUserSearchDTO req)
        {
            if (req.ListType == 1)
                req.offset = (req.offset - 1) * req.limit;

            var currentUser = OperatorProvider.Provider.GetCurrent();
            req.CompanyId = currentUser.CompanyId.ToInt();
            var list = companyUserRepository.GetCompanyUsers(out int total, req);
            return NewtonSoftJson(new { rows = list, total = total, code = 0, msg = "" }, JsonRequestBehavior.AllowGet);
        }

        public ActionResult GetCompanyRestaurants()
        {
            var currentUser = OperatorProvider.Provider.GetCurrent();
            var list = restaurantRepository.GetList(currentUser.CompanyId.ToInt());
            return Json(list);
        }

        [HttpPost]
        public ActionResult UpdateUserManagerRestaurant(UserDto user, List<int> restaurantIds)
        {
            var currentUser = OperatorProvider.Provider.GetCurrent();
            restaurantIds = restaurantIds == null ? new List<int>() : restaurantIds;
            var res = new Response() { Data = null, Successed = false };
            user.RoleId = currentUser.CompanyId;
            if (ModelState.IsValid)
            {
                try
                {
                    res.Data = companyUserRepository.UpdateUserManagerRestaurant(user, restaurantIds);
                    res.Successed = true;
                }
                catch (Exception e)
                {
                    res.Message = e.Message;
                    res.Data = false;
                }
            }
            else
            {
                res.Message = string.Join(",", ModelState.SelectMany(ms => ms.Value.Errors).Select(e => e.ErrorMessage));
            }
            return Json(res);
        }

        public ActionResult GetCompanyUseById(int id)
        {
            var currentUser = OperatorProvider.Provider.GetCurrent();
            var userInfo = companyUserRepository.GetCompanyUseById(id,currentUser.CompanyId.ToInt());
            var enumList = EnumHelper.GetEnumDic<Permission>(typeof(Permission));
            var restaurantList = restaurantRepository.GetList(currentUser.CompanyId.ToInt());
            return NewtonSoftJson(new { user = userInfo,permissions=enumList,restaurantList=restaurantList }, JsonRequestBehavior.AllowGet);
        }
    }
}