﻿#region

using System;
using Comrade.Domain.Enums;
using Microsoft.AspNetCore.Authorization;

#endregion

namespace Comrade.Core.Utils
{
    public static class SecurityModule
    {
        public static void RegisterPolicies(AuthorizationOptions options)
        {
            foreach (EnumRecursos recurso in Enum.GetValues(typeof(EnumRecursos)))
                options.AddPolicy(recurso.ToString(), policy =>
                    policy.RequireClaim("Recurso", recurso.ToString()));
        }
    }
}