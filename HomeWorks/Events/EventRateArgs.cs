using System;
using System.Collections.Generic;
using System.Text;

namespace Events
{
    class EventRateArgs : EventArgs
    {
        public decimal UsdRate {  get; init; }
        public decimal EurRate { get; init; }
        public decimal GbpRate {  get; init; }
    }
}
