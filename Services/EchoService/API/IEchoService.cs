using System.Threading;
using System.Threading.Tasks;

namespace API
{
    public interface IEchoService
    {
        string Echo(string echoRequest);
        Task<string> EchoAsync(string echoRequest, CancellationToken cancellationToken);
    }
}
