using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp31
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = Convert.ToInt32(Console.ReadLine());
            int max;

            List<int> list = new List<int>();
            list.Add(2);
            list.Add(3);
            list.Add(-1);
            list.Add(4);
            list.Add(4);
            int counter = 0;
            void MAX(List<int> _list)
            {
                max = list.Max();
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i] == max)
                    {
                        counter = i;
                    }
                }
                list[counter] = x;
            }

            MAX(list);

            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i] + " ");
            }
            Console.ReadLine();
        }
    }
}