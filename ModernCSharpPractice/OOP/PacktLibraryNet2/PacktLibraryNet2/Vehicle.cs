using System;
using System.Collections.Generic;
using System.Text;




namespace PacktLibraryNet2
{
    public class Vehicle
    {

        public string? ElectricEngine { get; set; }

        public string? CombustionEngine { get; set; }

        public string? HybridEngine   { get; set; }

        public virtual  void Start()
        {
            Console.WriteLine("Vehicle is starting...");
        }

    }

    public class Car : Vehicle
    {
 
        public override void Start()
        {
            Console.WriteLine("Car is starting...");
        }
      
    }

    public class Scooter : Vehicle
    {
        public override void Start()
        {
            Console.WriteLine("Scooter is starting...");
        }
    }



}
