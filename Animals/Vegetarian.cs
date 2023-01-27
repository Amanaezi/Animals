using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Vegetarian : Animal
    {
        public override (TypeOfFood, double) Food()
        {
            Count = Weight * 0.2;
            return (TypeOfFood.Herbal, Count);
        }
    }
}
