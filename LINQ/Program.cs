using LINQ.Classes;
using System;
using System.Collections.Generic;

namespace LINQ
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string Path = ("./../../../../../../../Linq.JSON ");

            ///1.Output all of the neighborhoods in this data list

            List<Properties> list = GetNeighbors(Getobj());
            Print(list);
            ///2.Filter out all the neighborhoods that do not have any names
            IEnumerable<Properties> result = FilterOutNoNeighbors(list);
            Print(result);

            ///3.Remove the Duplicates
            RemoveDuplicates(list);

            ///4.Rewrite the queries from above, and consolidate all into one single query.
            

        }

    }
}
