using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public abstract class Animal
    {
        public double Count { get; set; }
        public string Name { get; set; }
        public double Weight { get; set; }
        public double LengthWay { get; set; }
        public abstract (TypeOfFood, double) Food();
    }
}
