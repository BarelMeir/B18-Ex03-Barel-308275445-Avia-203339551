﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.GarageLogic
{
    interface IFuelable
    {
        void AddFuel(Vehicle.eEnergyType i_EnergyType, float i_AmountToAdd);
    }
}
