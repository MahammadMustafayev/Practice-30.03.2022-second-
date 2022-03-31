using Practice_03._31._2022_second__.Models;
using System;


namespace Practice_03._31._2022_second__
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car(4,1234,12,24,15,1200,1200,"Benzin",12,"Auto");
            //Console.WriteLine(car.AverageSpeed(12, 24));
            car.ShowInfo();
        }
    }
}
