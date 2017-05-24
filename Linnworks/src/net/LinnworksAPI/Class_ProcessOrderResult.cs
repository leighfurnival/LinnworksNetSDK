using System;

namespace LinnworksAPI
{
    public class ProcessOrderResult
    {
        public Guid OrderId;
        public bool Processed;
        public string Error;
    }
}