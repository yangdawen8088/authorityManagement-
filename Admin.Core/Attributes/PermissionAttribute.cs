﻿using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.DependencyInjection;
using Admin.Core.Auth;
using Admin.Core.Common.Auth;
using System.Threading.Tasks;

namespace Admin.Core.Attributes
{
    /// <summary>
    /// 启用权限
    /// </summary>
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true)]
    public class PermissionAttribute : AuthorizeAttribute, IAuthorizationFilter, IAsyncAuthorizationFilter
    {
        private async Task PermissionAuthorization(AuthorizationFilterContext context)
        {
            //排除匿名访问
            if (context.ActionDescriptor.EndpointMetadata.Any(m => m.GetType() == typeof(AllowAnonymousAttribute)))
                return;

            //登录验证
            var user = context.HttpContext.RequestServices.GetService<IUser>();
            if (user == null || !(user?.Id > 0))
            {
                context.Result = new ChallengeResult();
                return;
            }

            //排除登录接口
            if (context.ActionDescriptor.EndpointMetadata.Any(m => m.GetType() == typeof(LoginAttribute)))
                return;

            //权限验证
            var httpMethod = context.HttpContext.Request.Method;
            var api = context.ActionDescriptor.AttributeRouteInfo.Template;
            var permissionHandler = context.HttpContext.RequestServices.GetService<IPermissionHandler>();
            var isValid = await permissionHandler.ValidateAsync(api, httpMethod);
            if (!isValid)
            {
                context.Result = new ForbidResult();
            }
        }

        public async void OnAuthorization(AuthorizationFilterContext context)
        {
            await PermissionAuthorization(context);
        }

        public async Task OnAuthorizationAsync(AuthorizationFilterContext context)
        {
            await PermissionAuthorization(context);
        }
    }
}
