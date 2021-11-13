using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text.Json;
using System.Threading.Tasks;
using Zeynep.Ecommerse.BusinessLogic.DAL;

namespace Zeynep.Ecommerse.BusinessLogic.Infrastructure
{
    public class ErrorHandlerMiddleware
    {
        private readonly RequestDelegate _next;

        public ErrorHandlerMiddleware(RequestDelegate next)
        {
            _next = next;
        }

      
        public async Task Invoke(HttpContext context, DatabaseContext db)
        {
            try
            {
                await _next(context);
            }
            catch (Exception error)
            {
                var err = new GlobalException();
                err.ExceptionDate = DateTime.Now;
                err.ErrorMessage = error.Message;
                err.StackTrace = error.StackTrace;
                db.GlobalExceptions.Add(err);
                await db.SaveChangesAsync();


                var response = context.Response;
                response.ContentType = "application/json";

                var result = JsonSerializer.Serialize(new { message = error?.Message });
                await response.WriteAsync(result);
                
            }
        }
    }
}
