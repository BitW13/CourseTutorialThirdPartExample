using ConsoleAppThirdPartFirstLecture.Helpers;
using ConsoleAppThirdPartFirstLecture.Providers;
using ConsoleAppThirdPartFirstLecture.Routes;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleAppThirdPartFirstLecture.Runners
{
    public class ConsoleRunner : IRunner
    {
        private readonly IUIProvider provider;
        private readonly IRouter router;

        public ConsoleRunner(IUIProvider provider, IRouter router)
        {
            this.provider = provider;
            this.router = router;
        }

        public Task RunAsync(CancellationToken stoppingToken)
        {
            return Task.Run(() =>
                {
                    while (!stoppingToken.IsCancellationRequested)
                    {
                        router.Route(provider.State.ToArray());
                        provider.GetCommand();
                    }
                }
            );
        }
    }
}
