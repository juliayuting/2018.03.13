using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 數值判斷
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] number = new int[100];
           
            for (int i = 0; i <= number.Length-1; i++)
            {
                number[i] = i +1;
            }
            foreach(int item in number)
            {
                if (item % 15!= 0)
                {
                    Console.WriteLine(item);
                }
            }
            Console.ReadLine();
        }
    }
}
