using AsyncKeyedLock;
using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

[assembly: FunctionsStartup(typeof(AsyncKeyedLockerDITest.Startup))]

namespace AsyncKeyedLockerDITest
{
    public class Startup : FunctionsStartup
    {
        public override void Configure(IFunctionsHostBuilder builder)
        {
            builder.Services.AddSingleton<AsyncKeyedLocker<string>>();
        }
    }
}