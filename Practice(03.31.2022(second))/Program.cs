using Practice_03._31._2022_second__.Models;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace Practice_03._31._2022_second__
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car(1,"ASDqwe12",12,120,250,120,true,18,"auto");
            Console.WriteLine(car.AverageSpeed(12, 24));
            car.RemainOilAmount(110, 300);
            car.ShowInfo();


            Plane plane = new Plane(119, 12, 120, 100, 1500, true, 64);
            Console.WriteLine(plane.AverageSpeed(12, 120));
            plane.RemainOilAmount(1500, 100);
            plane.ShowInfo();

            Bicycle bicycle = new Bicycle("auto",12,120,12);
            Console.WriteLine(bicycle.AverageSpeed(12,120));
            bicycle.ShowInfo();
        }
    }
}
