﻿using Microsoft.Data.Edm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.OData.Builder;
using System.Web.Http.OData.Extensions;

namespace ODataWebAPI.API
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();
            config.Routes.MapODataServiceRoute("ODataRoute", "odata", GenerateEntityDataModel());
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
        private static IEdmModel GenerateEntityDataModel()
        {
            ODataModelBuilder builder = new ODataConventionModelBuilder();
            builder.EntitySet<Employee>("Employees");
            builder.EntitySet<Address>("Addresses");
            builder.EntitySet<Company>("Companies");

            return builder.GetEdmModel();
        }
    }
}
