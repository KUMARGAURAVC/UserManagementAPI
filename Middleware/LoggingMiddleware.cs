using Microsoft.AspNetCore.Http;
using System.Diagnostics;
using System.Threading.Tasks;

namespace UserManagementAPI.Middleware
{
    public class LoggingMiddleware
    {
        private readonly RequestDelegate _next;

        public LoggingMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            // Log request details
            Debug.WriteLine($"HTTP {context.Request.Method} {context.Request.Path}");

            await _next(context);

            // Log response details
            Debug.WriteLine($"Response Status Code: {context.Response.StatusCode}");
        }
    }
}