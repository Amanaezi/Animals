using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Predator : Animal
    {
        
        public override (TypeOfFood, double) Food()
        {
            Count = LengthWay * 0.01;
            return (TypeOfFood.Meat, Count);
        }
    }
}
