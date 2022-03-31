using Practice_03._31._2022_second__.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Practice_03._31._2022_second__.Models
{
    class Car : Vehicle, IEngine, IWheel, ITransmissionKind
    {
        private int _doorCount;
        public int DoorCount
        {
            get { return _doorCount; }
            set 
            {
                if (_doorCount>=2 && _doorCount<=6)
                {
                    _doorCount = value;
                }
            }
        }
        public int WinCode { get; set; }
        public override double DriveTime { get; set; }
        public override double DrivePath { get; set; }
        public int HorsePower { get; set; }
        public double TankSize { get; set; }
        public double CurrentOil { get; set; }
        public string FuelType { get; set; }
        public int WheelThickness { get; set; }
        public string TransmissionKind { get; set; }
        public Car(int doorCount, int winCode, double driveTime, double drivePath, int horsePower, double tankSize, double currentOil, string fuelType, int wheelThickness, string transmissionKind) : base(driveTime, drivePath)
        {
            DoorCount = doorCount;
            WinCode = winCode;
            HorsePower = horsePower;
            TankSize = tankSize;
            CurrentOil = currentOil;
            FuelType = fuelType;
            WheelThickness = wheelThickness;
            TransmissionKind = transmissionKind;
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
