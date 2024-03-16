using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ogrodnik_lab1
{
    public class Item
    {
        public Item(int weight, int prize, int number)
        {
            Weight = weight;
            Prize = prize;
            Number = number;
        }

        public int Weight { get; set; }
        public int Prize { get; set; }

        public int Number { get; set; }

        public double Value()
        {
            return Prize / Weight;
        }


    }
}
