﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Rental.Common.Interfaces
{
    public interface IVehicle
    {
        public string RegNo { get; init; }

        public string Make { get; init; }

        public int Odometer { get; init; }

        public double CostKm { get; init; }

        public string VehicleType { get; init; }

        public int CostDay { get; init; }

        public string Status { get; init; }
    }
}
