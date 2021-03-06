﻿using eStore.Domain.Security;
using eStore.Web.Infrastructure.ObjectMapper;
using eStore.Web.UI.Areas.Account.ViewModels;
using System;

namespace eStore.Web.UI.Logic
{
    public class AccountViewModelProfile : IProfile
    {
        public string ProfileName
        {
            get
            {
                return "AccountViewModel";
            }
        }

        public void Configure()
        {
            ObjectMapperConfigurator.Current.CreateMap<RegisterModel, User>();
        }
    }
}