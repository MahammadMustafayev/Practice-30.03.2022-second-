using System;
using System.Collections.Generic;
using System.Text;

namespace Practice_03._31._2022_second__.Utilities
{
    interface IEngine
    {
        public int HorsePower { get; set; }
        public double TankSize { get; set; }
        public double CurrentOil { get; set; }
        public string FuelType { get; set; }
        public void LeftFuelAmount();
        
    }
}
