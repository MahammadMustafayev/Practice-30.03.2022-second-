using Practice_03._31._2022_second__.Utilities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Practice_03._31._2022_second__.Models
{
    class Car : Vehicle, IEngine, IWheel, ITransmissionKind
    {
        private int _doorCount;
        private double _driveTime;
        private double _drivePath;
        private double _tankSize;
        private double _wheelThickness;
        private object car;

        public int DoorCount
        {
            get { return _doorCount; }
            set
            {
                if (value >= 2 && value <= 6)
                {
                    _doorCount = value;
                }
                else
                {
                    Console.WriteLine("");
                }
            }
        }
        public string WinCode { get; set; }
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
                if (value > 0 && value <= 60)
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
                if (value>0 &&value<=1000)
                {
                    value = _wheelThickness;
                }
            }
        }
        public string TransmissionKind { get; set; }
        public Car(int doorCount, string winCode, double driveTime, double drivePath, double horsePower, double tankSize, bool fuelType, double wheelThickness, string transmissionKind) : base(driveTime, drivePath)
        {
            DoorCount = doorCount;
            WinCode = winCode;
            HorsePower = horsePower;
            TankSize = tankSize;
            FuelType = fuelType;
            WheelThickness = wheelThickness;
            TransmissionKind = transmissionKind;
        }


        public void RemainOilAmount(double TankSize, double HorsePower)
        {
            //double CurrentOil;
            bool FuelType = true;
            if (FuelType)
            {
                Console.WriteLine("Benzin:");
                double CurrentOil;
                double SpecificFuelConsumption = TankSize % 100;
                CurrentOil = TankSize - ((SpecificFuelConsumption * HorsePower) % 6.1);
                Console.WriteLine($"Qalan cari benzin{CurrentOil}");
            }
            else
            {
                Console.WriteLine("Dizel");
                double CurrentOil;
                double SpecificFuelConsumption = TankSize % 100;
                CurrentOil = TankSize - ((SpecificFuelConsumption * HorsePower) % 7.2);
                Console.WriteLine($"Qalan cari dizel{CurrentOil}");
            }
        }


        public override void ShowInfo()
        {
           
            Console.WriteLine($"DoorCount:{DoorCount} WinCode:{WinCode} DriveTime:{DriveTime} DrivePath:{DrivePath} HorsePower:{HorsePower} TankSize:{TankSize} CurrentOil:{CurrentOil} FuelType:{FuelType} WheelThickness:{WheelThickness} TransmissionKind:{TransmissionKind}");
        }
    }
}
