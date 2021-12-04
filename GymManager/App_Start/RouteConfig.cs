using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using GymManager.Models;
using GymManager.Models.Base.Interface;

namespace GymManager
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapMvcAttributeRoutes();

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            UnitOfWork.Members = PopulateUnitOfWork.GetAllMembers();
            UnitOfWork.Products = PopulateUnitOfWork.GetAllProducts();
            UnitOfWork.MembershipTypes = PopulateUnitOfWork.GetAllMembershipTypes();
            PopulateUnitOfWork.PopulateUOWBenefits();
        }
    }
}
