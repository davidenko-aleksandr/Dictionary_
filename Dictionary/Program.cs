using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            var map = new Map<int, string>();
            map.Add(1, "Smith");
            map.Add(2, "Deniro");
            map.Add(3, "Sigal");
            map.Add(new Item<int, string>(4, "Lungren"));
            map.Add(new Item<int, string>(5, "Stallone"));

            ShowMap(map, "Created map");

            map.Update(5, "Kruz");
            ShowMap(map, "Updated map");

            map.Remove(1);
            ShowMap(map, "Cleared map");

        }

        private static void ShowMap(Map<int, string> map, string title)
        {
            
            Console.WriteLine($"{title}: ");

            foreach (var key in map.Keys)
            {
                var value = map.Get(key);
                Console.WriteLine($"{key} - {value}");
            }
        }
    }
}
