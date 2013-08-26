﻿using eStore.Domain;
using System;

namespace eStore.Interfaces.Services
{
    public interface IAuthenticationService
    {
        bool LogOn(string user, string password, bool rememberMe);
        void LogOff();
    }
}