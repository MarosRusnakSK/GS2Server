using System.Net;
using System.Threading;

namespace GS2.Shared.Transport
{
    public class DiscoveryState
    {
        public DiscoveryState(IPAddress interfaceAddress, CancellationTokenSource cts)
        {
            InterfaceAddress = interfaceAddress;
            Cts = cts;
        }

        public IPAddress InterfaceAddress { get; }

        public CancellationTokenSource Cts { get; }
    }
}
