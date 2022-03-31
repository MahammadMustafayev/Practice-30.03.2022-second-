using System;
using System.Collections.Generic;
using System.Text;

namespace Practice_03._31._2022_second__.Models
{
    abstract class Vehicle
    {
        public abstract double DriveTime { get; set; }
        public abstract double DrivePath { get; set; }
        public Vehicle(double driveTime, double drivePath)
        {
            DriveTime = driveTime;
            DrivePath = drivePath;
        }
        public double AverageSpeed(double DriveTime,double DrivePath)
        {
            return DrivePath / DriveTime;
        }   

        public abstract void ShowInfo();
        
    }
}
