﻿using eStore.Interfaces.Services;
using eStore.Web.Infrastructure.ObjectMapper;
using WrapIoC;

namespace eStore.Web.Infrastructure
{
    public static class WebInfraBootstrapper
    {
        public static void Init()
        {
            IoC.Current.Register<IAuthenticationProvider, AuthenticationProvider>();
            IoC.Current.Register<IObjectMapper, eStore.Web.Infrastructure.ObjectMapper.ObjectMapper>();
        }
    }
}