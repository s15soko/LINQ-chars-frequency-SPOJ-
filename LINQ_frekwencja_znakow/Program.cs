using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ_frekwencja_znakow
{
    class Program
    {
        static void Main(string[] args)
        {
            int testCases = int.Parse(Console.ReadLine());

            int size = testCases * 2;
            List<string> text = new List<string>();

            for(int i = 0; i < size; i++)
            {
                string tmp = "";
                while(tmp.Length == 0)
                {
                    tmp = Console.ReadLine();
                }

                text.Add(tmp);
            }

            for (int i = 0; i < size; i+=2)
            {
                string [] commands = text[i + 1].Split(" ");

                var results = (from myChar in text[i] select myChar)
                    .Select(myChar => Char.ToLower(myChar))
                    .Where(myChar => Char.IsLetter(myChar))
                    .GroupBy(groupedData => groupedData)
                    .Select(select => new
                    {
                        value = select.Key,
                        count = select.Count()
                    });

                var orderList = results.OrderBy(grouped => 0);
                for (int j = 0; j < commands.Length; j += 2)
                {
                    switch (commands[j])
                    {
                        case "byfreq":
                            if (commands[j + 1] == "asc")
                            {
                                orderList = orderList.ThenBy(grouped => grouped.count);
                            }
                            else if (commands[j + 1] == "desc")
                            {
                                orderList = orderList.ThenByDescending(grouped => grouped.count);
                            }

                            break;
                        case "byletter":

                            if (commands[j + 1] == "asc")
                            {
                                orderList = orderList.ThenBy(grouped => grouped.value);
                            }
                            else if (commands[j + 1] == "desc")
                            {
                                orderList = orderList.ThenByDescending(grouped => grouped.value);
                            }

                            break;
                    }
                }

                for (int j = 0; j < commands.Length; j += 2)
                {
                    switch (commands[j])
                    {
                        case "first":
                            results = orderList.Take(int.Parse(commands[j + 1]));
                            break;
                        case "last":
                            results = orderList.TakeLast(int.Parse(commands[j + 1]));
                            break;
                    }
                }

                if (orderList != null) {
                    foreach (var a in results) {
                        Console.WriteLine($"{a.value} {a.count}");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
