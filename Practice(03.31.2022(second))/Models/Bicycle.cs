using System;
using System.Collections.Generic;
using System.Text;
using Practice_03._31._2022_second__.Utilities;


namespace Practice_03._31._2022_second__.Models
{
    class Bicycle:Vehicle,IWheel
    {
        public string PedalKind { get; set; }
        public override double DriveTime { get; set; }
        public override double DrivePath { get; set; }
        public int WheelThickness { get; set; }
        public Bicycle(string pedalKind,double driveTime,double drivePath,int wheelThickness) :base(driveTime,drivePath)
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
