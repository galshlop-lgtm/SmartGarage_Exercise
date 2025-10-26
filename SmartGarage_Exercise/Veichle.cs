using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SmartGarage_Exercise
{
    public abstract class Veichle
    {
        public string ModelName { get; set; }
        public abstract void Drive();
        public abstract void MoveLeft();
        public abstract void MoveRight();

        public Veichle(string model)
        {
            ModelName = model;
        }
    }
}
