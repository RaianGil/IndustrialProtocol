using System;

namespace IndustrialProtocol.Models
{
    public class ReadParameters
    {
        public int intStart { get; set; }
        public int intLength { get; set; }
        public Action<byte[], bool> actPayload { get; set; }
    }
}
