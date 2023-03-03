using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadFramework
{
    internal class Program
    {

        #region Part1
/*
        public static void Count(object param)
        {
            var a = param;
            Count(param);
        }

        static void Main(string[] args)
        {
            Thread th1 = new Thread(new ParameterizedThreadStart(Count), 2_000_000_000);
            th1.Start(3.25D)
;
        }
*/
        #endregion

        public static void Count()
        {
            for (int i = 0; i < 25; i++)
            {
                Console.WriteLine($"From function:{i}");
            }
        }
        
        public static void Main(string[] args)
        {
            Thread th1 = new Thread(Count); 
            th1.Start();

            for (int i = 0; i < 25; i++)
            {
                Console.WriteLine($"From main:{i}");
            }
        }

    }
}
