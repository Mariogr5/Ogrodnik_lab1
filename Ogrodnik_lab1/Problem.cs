using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
[assembly: InternalsVisibleTo("BagpackTest"), InternalsVisibleTo("GUII")]
namespace Ogrodnik_lab1
{
    public class Problem
    {
        private int _n { get; set; }
        private int _seed { get; set; }

        public List<Item> problemItems;

        private List<Item> Items()
        {
            var rand = new Random(_seed);
            List<Item> itemList = new List<Item>();
            for(int i = 0; i <  _n; i++)
            {
                itemList.Add(new Item(rand.Next(1, 11), rand.Next(1, 11), i));
            }
            return itemList;
        }
        public Problem(int n, int seed)
        {
            _n = n;
            _seed = seed;
            problemItems = Items();
        }

        public Result Solve(int capacity)
        {
            var itemsInBagpack = new List<Item>();
            var bagpackCapacity = capacity;
            var userItems = problemItems;
            var sortedUserItems = userItems.OrderByDescending(x => x.Value()).ToList();

            foreach(var item in sortedUserItems)
            {
                if (item.Weight <= bagpackCapacity)
                {
                    itemsInBagpack.Add(item);
                    bagpackCapacity -= item.Weight;
                }
                    
            }
            return new Result(itemsInBagpack);
        }

        public override string ToString()
        {
            string userstring = "";
            foreach(var item in problemItems)
            {
                userstring += ("Item no: " + item.Number + " Weight: " + item.Weight + " Prize: " + item.Prize + "\n");
            }
            return userstring;
        }
    }
}
