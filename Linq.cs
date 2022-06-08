using System;
using System.Collections.Generic;
using System.Linq;
namespace Linq_1
{
    class Linq
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() {1,3,-2,-4,-7,-3,-8,12,19,6,9,10,14};
            IEnumerable<int> filteringQuery =
              from num in list
              where num >= 1 && num <= 14
              select num;
            foreach (int i in filteringQuery)
                Console.Write(i + " ");
        }
    }
}