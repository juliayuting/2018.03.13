using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LED
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            Console.WriteLine("輸入一個字串：");
            input = Console.ReadLine();
            char[] arrayinput = input.ToCharArray();
            for(int i = 0; i <= arrayinput.Length - 1; i++)
            {
                switch (int.Parse(arrayinput[i].ToString()))
                {
                    case 1:
                        Console.Write("   ");
                        break;
                    case 2:
                        Console.Write(" _ ");
                        break;
                    case 3:
                        Console.Write(" _ ");
                        break;
                    case 4:
                        Console.Write("   ");
                        break;
                    case 5:
                        Console.Write(" _ ");
                        break;
                    case 6:
                        Console.Write(" _ ");
                        break;
                    case 7:
                        Console.Write(" _ ");
                        break;
                    case 8:
                        Console.Write(" _ ");
                        break;
                    case 9:
                        Console.Write(" _ ");
                        break;
                    default:
                        break;
                }                
            }
            Console.WriteLine();
            for(int i = 0; i <= arrayinput.Length - 1; i++)
            {
                switch (int.Parse(arrayinput[i].ToString()))
                {
                    case 1:
                        Console.Write("  |");
                        break;
                    case 2:
                        Console.Write(" _|");
                        break;
                    case 3:
                        Console.Write(" _|");
                        break;
                    case 4:
                        Console.Write("|_|");
                        break;
                    case 5:
                        Console.Write("|_ ");
                        break;
                    case 6:
                        Console.Write("|_ ");
                        break;
                    case 7:
                        Console.Write("  |");
                        break;
                    case 8:
                        Console.Write("|_|");
                        break;
                    case 9:
                        Console.Write("|_|");
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine();
            for(int i = 0; i <= arrayinput.Length - 1; i++)
            {
                switch (int.Parse(arrayinput[i].ToString()))
                {
                    case 1:
                        Console.Write("  |");
                        break;
                    case 2:
                        Console.Write("|_ ");
                        break;
                    case 3:
                        Console.Write(" _|");
                        break;
                    case 4:
                        Console.Write("  |");
                        break;
                    case 5:
                        Console.Write(" _|");
                        break;
                    case 6:
                        Console.Write("|_|");
                        break;
                    case 7:
                        Console.Write("  |");
                        break;
                    case 8:
                        Console.Write("|_|");
                        break;
                    case 9:
                        Console.Write(" _|");
                        break;
                    default:
                        break;
                }
            }

            //List<string> number;
            //number = new List<string>();
            //number.Add(" _   _   _   _       _   _     ");
            //number.Add("  | |_|  _| |_| |_| |_   _|  | ");
            //number.Add("  |  _|  _| |_|   |  _| |_   | ");
            //foreach(string item in number)
            //{
            //    Console.WriteLine(item);
            //}

            //switch (y)
            //{
            //    case 1:
            //        Console.WriteLine("|" + '\n' + "|");
            //        break;
            //    default:
            //        break;
            //}


            Console.ReadLine();
        }     
    }
}
