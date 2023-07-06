﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_last
{
    internal static class StaticDemo
    {
        static int cno=123, pre=10850, curr=11000;
        static double amt;

        public static int Cno { get => cno; set => cno = value; }
        public static int Pre { get => pre; set => pre = value; }
        public static int Curr { get => curr; set => curr = value; }
        public static double Amt { get => amt; set => amt = value; }

        static StaticDemo() 
        {
            if((Curr-Pre)<100)
            {
                Amt = 0;
            }
            Console.WriteLine("hjki");
        }

        public static double calc()
        {
            int usage = Curr - Pre;
            if (usage > 100 && usage<=200)
            {
                Amt =usage *2;
            }
            else
                Amt = usage*5;
            return Amt;
        }

    }
}
