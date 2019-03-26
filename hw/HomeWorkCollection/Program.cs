using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int count = 7;
            List<int> array = new List<int>();
            while (array.Count()!= count)
            {
                array.Add(rand.Next(50));
            }
            foreach (int i in array)
            {
                Console.WriteLine(i);
            }

            int tmp=array.Min();
            int sum = 0;
            foreach (int i in array)
            {
                if (i > tmp && i < array.Max())
                    tmp = i;
                if (array.IndexOf(i) % 2 == 0)
                    sum += i;
            }
            Console.WriteLine($"Второе максимальное число: {tmp}, позиция: {array.IndexOf(tmp)},\nСумма элементов на четных позициях: {sum}");
            
        }
    }
}
