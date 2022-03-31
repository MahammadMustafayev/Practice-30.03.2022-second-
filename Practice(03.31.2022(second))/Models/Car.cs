using Practice_03._31._2022_second__.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Practice_03._31._2022_second__.Models
{
    class Car:Vehicle, IEngine,IWheel,ITransmissionKind
    {
        public int DoorCount { get; set; }
        public int WinCode { get; set; }
        public override int DriveTime { get; set; }
        public override int DrivePath { get; set; }
        public int HorsePower { get; set; }
        public double TankSize { get; set; }
        public double CurrentOil { get; set; }
        public string FuelType { get; set; }
        public int WheelThickness { get; set; }
        public bool TransmissionKind { get; set; }

        public override void AverageSpeed()
        {

        }

        public void LeftFuelAmount()
        {

        }

        public override void ShowInfo()
        {
            Console.WriteLine($"DoorCount:{DoorCount} WinCode:{WinCode} DriveTime:{DriveTime} DrivePath:{DrivePath} HorsePower:{HorsePower} TankSize:{TankSize} CurrentOil:{CurrentOil} FuelType:{FuelType} WheelThickness:{WheelThickness} TransmissionKind:{TransmissionKind}");
        }
    }
}
