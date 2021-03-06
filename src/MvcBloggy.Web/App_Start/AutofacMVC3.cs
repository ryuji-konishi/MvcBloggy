﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Autofac;
using Autofac.Integration.Mvc;
using MvcBloggy.Web.Infrastructure.Services;
using MvcBloggy.Web.Infrastructure.MetaWeblogItems;
using MvcBloggy.API.Client.Http;
using MvcBloggy.API.Client.Services;
using MvcBloggy.API.Model.Dtos;

namespace MvcBloggy.Web {

    internal class AutofacMVC3 {

        public static void Initialize() {

            var builder = new ContainerBuilder();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(RegisterServices(builder)));
        }

        private static IContainer RegisterServices(ContainerBuilder builder) {

            builder.RegisterControllers(typeof(MvcApplication).Assembly).PropertiesAutowired();

            //services
            builder.RegisterType<ApplicationSettings>().As<IApplicationSettings>().InstancePerHttpRequest().SingleInstance();
            builder.RegisterType<FormsAuthenticationService>().As<IFormsAuthenticationService>().InstancePerHttpRequest();

            //core
            builder.RegisterType<MetaWeblog>().As<IMetaWeblog>().InstancePerLifetimeScope();

            //httpClient
            builder.RegisterType<BlogHttpClient<BlogPostDto>>().As<IHttpApiClient<BlogPostDto, Guid>>();

            return builder.Build();
        }
    }
}