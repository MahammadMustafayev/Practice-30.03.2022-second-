using System;
using System.Collections.Generic;
using System.Text;
using Practice_03._31._2022_second__.Utilities;


namespace Practice_03._31._2022_second__.Models
{
    class Bicycle:Vehicle,IWheel
    {
        public string PedalKind { get; set; }
        public override int DriveTime { get; set; }
        public override int DrivePath { get; set; }
        public int WheelThickness { get; set; }

        public override void AverageSpeed()
        {
            /*Drivepath / DriveTime */

        }

        public override void ShowInfo()
        {
            Console.WriteLine($"PedalKind:{PedalKind} DriveTime:{DriveTime} DrivePath:{DrivePath} WheelThickness:{WheelThickness}");
        }
    }
}
