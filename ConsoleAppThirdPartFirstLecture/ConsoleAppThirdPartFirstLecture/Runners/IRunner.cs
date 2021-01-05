using System.Threading;
using System.Threading.Tasks;

namespace ConsoleAppThirdPartFirstLecture.Runners
{
    public interface IRunner
    {
        Task RunAsync(CancellationToken stoppingToken);
    }
}
