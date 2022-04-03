using System;
using System.Collections.Generic;
using System.Text;
using Practice_03._31._2022_second__.Utilities;


namespace Practice_03._31._2022_second__.Models
{
    class Bicycle : Vehicle, IWheel
    {
        private double _driveTime;
        private double _drivePath;
        private double _wheelThickness;

        public string PedalKind { get; set; }
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
        public double WheelThickness
        {
            get
            {
                return _wheelThickness;
            }
            set
            {
                if (value > 0 && value <=25)
                {
                    value = _wheelThickness;
                }
            }
        }
       
        public Bicycle(string pedalKind, double driveTime, double drivePath, double wheelThickness) : base(driveTime, drivePath)
        {
            PedalKind = pedalKind;
            WheelThickness = wheelThickness;
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"PedalKind:{PedalKind} DriveTime:{DriveTime} DrivePath:{DrivePath} WheelThickness:{WheelThickness}");

        }
    }
}
