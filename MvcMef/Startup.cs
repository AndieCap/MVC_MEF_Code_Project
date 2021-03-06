﻿using Microsoft.Owin;
using Owin;
using System.Reflection;
using System.Web.Mvc;
using MvcMef.Web;
using MvcMef.Dependencies;
using MvcMef.Models;

[assembly: OwinStartupAttribute(typeof(MvcMef.Startup))]
namespace MvcMef
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);

            MefBootstrap.Intialize();

            ControllerBuilder.Current.SetControllerFactory(new MefControllerFactory(MefBootstrap.Container));
           // ModelBinders.Binders.DefaultBinder = new InterfaceModelBinder();



        }
    }
}
