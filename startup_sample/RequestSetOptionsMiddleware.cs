using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Options;
using startup_sample.Models;
using System;
using System.Net;
using System.Threading.Tasks;

namespace startup_sample {
    public class RequestSetOptionsMiddleware {
        private readonly RequestDelegate _next;
        private IOptions<AppOptions> _injectedOptions;

        public RequestSetOptionsMiddleware(RequestDelegate next, IOptions<AppOptions> injectedOptions) {
            _next = next;
            _injectedOptions = injectedOptions;
        }
        public async Task Invoke(HttpContext httpContext) {
            Console.WriteLine("RequestSetOptionsMiddleware.Invoke");

            var option = httpContext.Request.Query["option"];

            if (!string.IsNullOrWhiteSpace(option)) {
                _injectedOptions.Value.Option = WebUtility.HtmlEncode(option);
            }

            await _next(httpContext);
        }
    }
}
