using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaumarktSystem.Data.Initializer
{
    public class DatabaseInitializationMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly IDateBaseInitializerInterface _dateBaseInitializer;

        public DatabaseInitializationMiddleware(RequestDelegate next, IDateBaseInitializerInterface dateBaseInitializer)
        {
            _next = next;
            _dateBaseInitializer = dateBaseInitializer;
        }

        public async Task Invoke(HttpContext context)
        {
            _dateBaseInitializer.Initialize();

            // Извикайте следващия middleware в веригата
            await _next(context);
        }
    }

}
