using API;
using Domain;
using System.Threading;
using System.Threading.Tasks;

namespace ApplicationServices
{
    public class EchoService : IEchoService
    {
        private readonly IEchoDomainService _echoDomainService;

        public EchoService(IEchoDomainService echoDomainService)
        {
            _echoDomainService = echoDomainService;
        }
        public string Echo(string echoRequest)
        {
            return _echoDomainService.Echo(echoRequest);
        }

        public Task<string> EchoAsync(string echoRequest, CancellationToken cancellationToken)
        {
            return Task.Run(() =>
            {
                return _echoDomainService.Echo(echoRequest);
            }, cancellationToken);
        }
    }
}
