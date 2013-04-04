using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HelloGit1
{
    class Program
    {
        static void Main(string[] args)
        {
            double da = 1;
            DateTime dt = new DateTime(2013,4, 2);
            DateTime dt1 = new DateTime(2013, 6, 20);
            da = (dt - dt1).TotalDays / 2 + 1;
            dt = dt.AddDays(da);
            short d = (short)dt.DayOfWeek;
            Console.WriteLine("kent dfaf faf adf kent");
            Console.WriteLine("GetForture : " + GetForture());
            Console.ReadKey();
        }

        private static string GetForture()
        {
            Random rnd = new Random();
            int whichone = rnd.Next(3);
            string tmp = "";
            switch (whichone)
            {
                case 1:
                    tmp  = "1";
                    break;
                case 2:
                    tmp =  "2";
                    break;
                case 3:
                    tmp = "3";
                    break;
                default:
                    tmp = "default";
                    break;

            }
            return tmp;
        }
        
    }
}
