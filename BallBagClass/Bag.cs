using System;
using System.Collections.Generic;
using System.Linq;

namespace BallBagClass
{
    public class Bag : List<int>
    {
        public static int TotalBags = 0;

        private readonly int id;

        public Bag()
        {
            id = TotalBags+1;
            TotalBags++;
        }

        public override string ToString()
        {
            string s = $"Bag #{id}:";
            if (this.Count < 1)
            {
                s += " <empty>;";
            }
            else
            {
                foreach(var item in this)
                {
                    s += $" {item},";
                }
                s = s.TrimEnd(','); s += ';';
            }
            return s;
        }

        public static int GetNumberOfBags() => TotalBags;
    }
}
