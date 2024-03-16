using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ogrodnik_lab1
{
    public class Result
    {
        public Result(List<Item> items)
        {
            Items = items;
            summaricWeight = summaric_weight_value();
            summaricPrize = summaric_prize_value();
        }

        public List<Item> Items { get; set; }

        public int summaricWeight { get; set; }
        public int summaricPrize { get; set; }


        private int summaric_weight_value()
        {
            int weight = 0;
            foreach(var item in Items)
            {
                weight += item.Weight;
            }
            return weight;
        }

        private int summaric_prize_value()
        {
            int prize = 0;
            foreach (var item in Items)
            {
                prize += item.Prize;
            }
            return prize;
        }




        public override string ToString()
        {

            string result = "";
            if (Items.Count == 0)
                return result;
            result += "Numbers of Elements: ";
            foreach(var item in Items)
            {
                result += (item.Number + " ");
            }
            result += "\n";
            result += ("Total Weight: " + summaricWeight + "\n");
            result += ("Total Prize: " + summaricPrize + "\n");
            foreach(var item in Items)
            {
                result += ("Item no: " + item.Number + " Weight: " + item.Weight + " Prize: " + item.Prize + "\n");
            }
            return result;
        }
    }
}
