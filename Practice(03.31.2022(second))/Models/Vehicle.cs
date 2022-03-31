using System;
using System.Collections.Generic;
using System.Text;

namespace Practice_03._31._2022_second__.Models
{
    abstract class Vehicle
    {
        public abstract int DriveTime { get; set; }
        public abstract int DrivePath { get; set; }
        public abstract void AverageSpeed();

        public abstract void ShowInfo();
        
    }
}
