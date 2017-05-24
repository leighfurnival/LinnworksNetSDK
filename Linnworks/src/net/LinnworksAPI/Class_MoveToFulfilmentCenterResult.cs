using System;
using System.Collections.Generic;

namespace LinnworksAPI
{
    public class MoveToFulfilmentCenterResult
    {
        public List<string> Errors;
        public List<Guid> OrdersMoved;
    }
}