﻿using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AjaxContatos.Mvc.Startup))]
namespace AjaxContatos.Mvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
