using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using ProjectOne.Entity.MySql;
using ProjectOne.Repository;

namespace ProjectOne.Service.Middlewares
{
    public class RegisterMiddleware
    {
        private RequestDelegate _next;

        public RegisterMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context, IRepositoryWrapper repository)
        {

            User user;
            using (var streamReader = new StreamReader(context.Request.Body))
            {
                var bodyData = await streamReader.ReadToEndAsync();
                user = JsonConvert.DeserializeObject<User>(bodyData);
            }

            user = await repository.UserRepository.CreateAsync(user);

            await _next.Invoke(context);
        }
    }
}