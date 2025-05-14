using System.Diagnostics;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace MiddlewareApp.Middleware
{
    public class RequestTimingMiddleware
    {
        private readonly RequestDelegate _next;

        public RequestTimingMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            var sw = Stopwatch.StartNew();

            await _next(context);  // Gọi middleware tiếp theo trong pipeline

            sw.Stop();

            Console.WriteLine($"[RequestTiming] Path: {context.Request.Path}, Time taken: {sw.ElapsedMilliseconds} ms");
        }
    }
}
