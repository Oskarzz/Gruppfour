using System.Threading.Tasks;

namespace EventService.Services
{
    public interface ILogger
    {
        Task<bool> LoggAsync(string serviceName, string loggEventType, string message);
    }
}