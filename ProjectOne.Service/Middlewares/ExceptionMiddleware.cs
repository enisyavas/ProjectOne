using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace ProjectOne.Service.Middlewares
{
    public class ExceptionMiddleware
    {
        private RequestDelegate _next;

        public ExceptionMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await _next.Invoke(context);
            }
            catch (Exception ex)
            {
                context.Response.StatusCode = StatusCodes.Status500InternalServerError;
                await context.Response.WriteAsync("Hey Man, created error :( \n" + ex.Message);
            }
        }

    }
}