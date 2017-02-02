using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;

namespace Infomed.Core.Middleware
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class TimeLoggerMiddleware
    {
        private readonly ILogger _log;
        private readonly RequestDelegate _next;

        public TimeLoggerMiddleware(RequestDelegate next, ILogger log)
        {
            _next = next;
            _log = log;
        }

        public Task Invoke(HttpContext httpContext)
        {
            _log.LogInformation(DateTime.Now.ToString());
            return _next(httpContext);
        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class TimeLoggerMiddlewareExtensions
    {
        public static IApplicationBuilder UseTimeLoggerMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<TimeLoggerMiddleware>();
        }
    }
}
