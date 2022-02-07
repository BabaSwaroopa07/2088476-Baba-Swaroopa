using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPatternFinalCheck
{
    interface IObserver
    {
        int Ticket { get; set; }
        string EventName { get; set; }
        void Notify();
    }
}
