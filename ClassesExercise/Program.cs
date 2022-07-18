using System;

namespace ClassesExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var car = new Car();
            car.Make = "Nissan";
            car.Model = "Altima";
            car.Year = 1993;

            Console.WriteLine($"Make: {car.Make}\nModel: {car.Model}\nYear: {car.Year}");
        }
    }
}