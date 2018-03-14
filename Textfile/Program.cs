using System;
using System.Collections.Generic;
using System.IO;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Textfile.Models;

namespace Textfile
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = "test03.txt";

            if (File.Exists(fileName))
            {
                var lines = File.ReadAllLines(fileName);

                foreach (string item in lines)
                {
                    if (item.Substring(0, 3) == "625" || item.Substring(0, 3) == "525")
                    {                       
                        if(DateTime.TryParseExact(item.Substring(13,20),"yyyyMMdd",null,DateTimeStyles.None,out DateTime d1))
                        {
                            if (DateTime.TryParseExact(item.Substring(21, 28), "yyyyMMdd", null, DateTimeStyles.None, out DateTime d2))
                            {
                                Table data = new Table()
                                {
                                    TickNumber = item.Substring(0, 7),
                                    FlyingDay=d1,
                                    Birthday=d2
                                };
                                try
                                {
                                    ContactsModel contacts=
                                }
                            }
                        }
                    }
                }
                
            }            
            Console.ReadLine();
        }
    }
}
