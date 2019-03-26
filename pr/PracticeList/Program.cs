using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> arrayList = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13};
            
            List<int> tmpArr = new List<int>();
            foreach (int value in arrayList)
            {
                if (value % 2==0)
                {
                    tmpArr.Add(value);
                }
            }
            
            arrayList.Clear();
            
            arrayList = tmpArr;
            
            foreach (int value in arrayList)
            {
                Console.WriteLine(value);
            }
            Console.WriteLine("2 задание");
            foreach (int value in arrayList)
            {
                if(value > arrayList.Average())
                    Console.WriteLine(value);
            }


        }
    }
}
