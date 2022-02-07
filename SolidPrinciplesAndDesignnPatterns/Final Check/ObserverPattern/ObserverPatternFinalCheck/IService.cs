﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPatternFinalCheck
{
    interface IService
    {
        void AddSubscriber(IObserver notificationObserver);
        void RemoveSubscriber(IObserver notificationObserver);
        void NotifySubscriber();
    }
}
