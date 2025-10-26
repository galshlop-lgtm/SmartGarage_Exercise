using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartGarage_Exercise;
	

/// <summary>
/// מייצגת מכונית בעלת מנוע דלק.
/// </summary>
public class Car(string model, int fuel) : Veichle(model), IMoveble
{
    /// <summary>
    /// אחוז הדלק הנוכחי (בין 0 ל-100).
    /// </summary>
    public int FuelPercentage { get; private set; } = Math.Clamp(fuel, 0, 100);

    /// <summary>
    /// מבצע פעולת נסיעה הצורכת דלק.
    /// </summary>
    public override void Drive()
    {
        if (FuelPercentage > 10)
        {
            FuelPercentage -= 10;
            Console.WriteLine($"The car {ModelName} goes 'Vroom Vroom'. Fuel left: {FuelPercentage}%");
        }
        else
        {
            Console.WriteLine($"The car {ModelName} cannot drive. No fuel.");
        }
    }

    /// <summary>
    /// מתדלק את המכונית למקסימום.
    /// </summary>
    public void Refuel()
    {
        Console.WriteLine($"Refueling {ModelName}...");
        FuelPercentage = 100;
    }

    /// <summary>
    /// מזיז את המכונית שמאלה.
    /// </summary>
    public override void MoveLeft()
    {
        Console.WriteLine($"Car {ModelName} turns left.");
    }

    /// <summary>
    /// מזיז את המכונית ימינה.
    /// </summary>
    public override void MoveRight()
    {
        Console.WriteLine($"Car {ModelName} turns right.");
    }
}

	
