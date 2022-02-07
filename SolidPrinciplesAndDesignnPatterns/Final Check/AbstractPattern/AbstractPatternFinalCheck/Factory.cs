﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractPatternFinalCheck
{
    abstract class Factory
    {
        public abstract void ElectronicOrder(channel channel);
        public abstract void ToysOrder(channel channel);
        public abstract void FurnitureOrder(channel channel);
    }
}
