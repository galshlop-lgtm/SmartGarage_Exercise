using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartGarage_Exercise
{
	/// <summary>
	/// מייצג אופנוע בעל מנוע דלק.
	/// </summary>
	  public class Motorcycle : Veichle, IMoveble
    {
        public string ModelName
        {
            get; set;
        }

        public int FuelPercentage
        {
            get; private set;
        }

        // Fix CS7036: Pass 'model' to base constructor
        // Fix IDE0290: Use primary constructor
        public Motorcycle(string model, int fuel) : base(model)
        {
            ModelName = model;
            FuelPercentage = Math.Clamp(fuel, 0, 100);
        }

        public override void Drive()
        {
            if (FuelPercentage > 5)
            {
                FuelPercentage -= 5;
                Console.WriteLine($"The motorcycle {ModelName} goes 'Neeeeow'. Fuel left: {FuelPercentage}%");
            }
            else
            {
                Console.WriteLine($"The motorcycle {ModelName} cannot drive. No fuel.");
            }
        }

        public void Refuel()
        {
            Console.WriteLine($"Refueling {ModelName}...");
            FuelPercentage = 100;
        }

        public override void MoveLeft()
        {
            Console.WriteLine($"Motorcycle {ModelName} leans left.");
        }

        public override void MoveRight()
        {
            Console.WriteLine($"Motorcycle {ModelName} leans right.");
        }
    }

}
