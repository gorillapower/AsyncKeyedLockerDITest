using System;
using System.IO;
using System.Threading.Tasks;
using AsyncKeyedLock;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AsyncKeyedLockerDITest
{
    public class HealthCheck
    {
        public HealthCheck(IServiceProvider provider)
        {
            var locker = provider.GetService<AsyncKeyedLocker<string>>();
        }

        [FunctionName("HealthCheck")]
        public async Task<IActionResult> HealthCheckAsync(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = "hc")] HttpRequest req,
            ILogger log)
        {
            return new OkResult();
        }
    }
}
