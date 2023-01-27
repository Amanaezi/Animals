using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Omnivores : Animal
    {
        public override (TypeOfFood, double) Food()
        {
            double herbal = Weight * 0.2;
            double meat = LengthWay * 0.01;

            if (herbal < meat)
            {
                Count = herbal;
                return (TypeOfFood.Herbal, Count);
            }
            else 
            {
                Count = meat;
                return (TypeOfFood.Herbal, Count);
            }
            
        }
    }
}
