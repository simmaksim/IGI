using Microsoft.AspNetCore.Builder;
using WEB_953506_SLIZH.Middleware;

namespace WEB_953506_SLIZH.Extensions
{
    public static class appExtensions
    {
        public static IApplicationBuilder UseFileLogging(this IApplicationBuilder app)
            => app.UseMiddleware<LogMiddleware>();
    }
}
