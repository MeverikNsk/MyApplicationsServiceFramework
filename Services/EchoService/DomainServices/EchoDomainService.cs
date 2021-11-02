using Domain;

namespace DomainServices
{
    public class EchoDomainService : IEchoDomainService
    {
        public string Echo(string echoRequest)
        {
            return $"echo \"{echoRequest}\"";
        }
    }
}
