using LINQ.Classes;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;


namespace LINQ
{
    public class Program
    {
        public static void Main(string[] args)
        {

            ///1.Output all of the neighborhoods in this data list

            List<Properties> list = GetNeighbors(GetObj());
            Print(list);
            ///2.Filter out all the neighborhoods that do not have any names
            IEnumerable<Properties> result = FillterOutNoNameNeighbors(list);
            Print(result);

            ///3.Remove the Duplicates
            RomoveDuplicate(list);

            ///4.Rewrite the queries from above, and consolidate all into one single query.
            IEnumerable<Properties> res = FillterOutNoNameNeighborsLamda(list);
            Print(res);


        }
        //question 1////////
        public static List<Properties> GetNeighbors(JObject jObject)
        {
            var obj = jObject["features"];
            List<Properties> neighbors = new List<Properties>();
            foreach (var item in obj)
            {
                Properties property = new Properties
                {
                    zip = (string)item["properties"]["zip"],
                    city = (string)item["properties"]["zip"],
                    state = (string)item["properties"]["zip"],
                    address = (string)item["properties"]["zip"],
                    borough = (string)item["properties"]["zip"],
                    neighborhood = (string)item["properties"]["zip"],
                    county = (string)item["properties"]["zip"],
                };
                neighbors.Add(property);
            }
            return neighbors;

        }
        /// <summary>
        /// Removing Dupliactes
        /// </summary>
        /// <param name="list"></param>
        
        /// //Question 2
        public static void RomoveDuplicate(List<Properties> list)

        {
            int i = 0;
            List<string> distinctElements = new List<string>();
            while (i < list.Count)
            {
                if (!distinctElements.Contains(list[i].neighborhood))
                    //collect all the distinct items then add it to the list.
                    distinctElements.Add(list[i].neighborhood);
                i++;
            }

            foreach (var item in distinctElements)
            {
                Console.WriteLine(item);
            }
        }



        ///Question 3
        public static IEnumerable<Properties> FillterOutNoNameNeighbors(List<Properties> list)
            //Filtering out
        {
            IEnumerable<Properties> result = from n in list
                                             where n.neighborhood.Length != 0
                                             select n;
            return result;
        }
        //Question 4
        public static IEnumerable<Properties> FillterOutNoNameNeighborsLamda(List<Properties> list)

        {
            var result = list.Where((n) => n.neighborhood.Length != 0);

            return result;
        }

    }
        public static void Print(List<Properties> list)

        {
        foreach (Properties n in list)

        {
            Console.WriteLine($" {n.neighborhood}");
        }
    }


    public static JObject Jobject()


    {
        var stream = File.OpenText("./../../../../../../../Linq.JSON ");

        string st = stream.ReadToEnd();

        JObject GetObj = JObject.Parse(st);

        return GetObj;

    }
    public static void Print (IEnumerable<Properties> result)

    {
        foreach (Properties n in result)

        {
            Console.WriteLine($" {n.neighborhood}");

        }
    }
}



