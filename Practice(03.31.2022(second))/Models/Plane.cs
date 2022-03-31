using Practice_03._31._2022_second__.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Practice_03._31._2022_second__.Models
{
    class Plane : Vehicle, IEngine, IWheel
    {
        public int WingLength
        {
            get; set;
        }
        public override double DriveTime { get; set; }
        public override double DrivePath { get; set; }
        public int HorsePower { get; set; }
        public double TankSize { get; set; }
        public double CurrentOil { get; set; }
        public string FuelType { get; set; }
        public int WheelThickness { get; set; }
        public Plane(int wingLength, double driveTime, double drivePath, int horsePower, double tankSize, double currentOil, string fuelType, int wheelThickness) : base(driveTime, drivePath)
        {
            WingLength = wingLength;
            HorsePower = horsePower;
            TankSize = tankSize;
            CurrentOil = currentOil;
            FuelType = fuelType;
            WheelThickness = wheelThickness;
        }
        public void LeftFuelAmount()
        {

        }

        public override void ShowInfo()
        {
            Console.WriteLine($"WingLength:{WingLength}  DriveTime:{DriveTime} DrivePath:{DrivePath} HorsePower:{HorsePower} TankSize:{TankSize} CurrentOil:{CurrentOil} FuelType:{FuelType} WheelThickness:{WheelThickness} ");

        }
    }
}
