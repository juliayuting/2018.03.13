using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 回文測試
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            Console.WriteLine("輸入一個字串：");
            input = Console.ReadLine();
            char[] arrayinput = input.ToCharArray();
            Array.Reverse(arrayinput);
            string output = new string(arrayinput);
            if (input == output)
            {
                Console.WriteLine(input + " 是回文");
            }
            else
            {
                Console.WriteLine(input + " 不是回文");
            }
            Console.ReadLine();
        }
    }
}
