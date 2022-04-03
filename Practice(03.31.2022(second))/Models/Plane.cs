using Practice_03._31._2022_second__.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Practice_03._31._2022_second__.Models
{
    class Plane : Vehicle, IEngine, IWheel
    {
        private double _driveTime;
        private double _drivePath;
        private double _tankSize;
        private double _wheelThickness;
        private int _wingLength;
        public int WingLength
        {
            get 
            {
                return _wingLength;
            }
            set 
            {
                if (value>0 && value<=117)
                {
                    value = _wingLength;
                }
            }
        }
        public override double DriveTime 
        {
            get
            {
                return _driveTime;
            }
            set
            {
                if (value > 0 && value <= 24)
                {
                    value = _driveTime;
                }
            }
        }
        public override double DrivePath
        {
            get
            {
                return _drivePath;
            }
            set
            {

            }
        }
        public double HorsePower { get; set; }
        public double TankSize 
        {
            get
            {
                return _tankSize;
            }
            set
            {
                if (value > 0 && value <= 600)
                {
                    _tankSize = value;
                }
            }
        }
        public double CurrentOil { get; set; }
        public bool FuelType { get; set; }
        public double WheelThickness 
        {
            get
            {
                return _wheelThickness;
            }
            set
            {
                if (value > 0 && value <= 1000)
                {
                    value = _wheelThickness;
                }
            }
        }
        public Plane(int wingLength, double driveTime, double drivePath, int horsePower, double tankSize,  bool fuelType, double wheelThickness) : base(driveTime, drivePath)
        {
            WingLength = wingLength;
            HorsePower = horsePower;
            TankSize = tankSize;
            FuelType = fuelType;
            WheelThickness = wheelThickness;
        }
        public void RemainOilAmount(double TankSize, double HorsePower)
        {
            
            double CurrentOil;
            double SpecificFuelConsumption = TankSize % 100;
            CurrentOil = TankSize - ((SpecificFuelConsumption * HorsePower) / 6.1);
            Console.WriteLine($"Qalan cari benzin{CurrentOil}");

        }

        public override void ShowInfo()
        {
            Console.WriteLine($"WingLength:{WingLength}  DriveTime:{DriveTime} DrivePath:{DrivePath} HorsePower:{HorsePower} TankSize:{TankSize} CurrentOil:{CurrentOil} FuelType:{FuelType} WheelThickness:{WheelThickness} ");
        }
    }
}
