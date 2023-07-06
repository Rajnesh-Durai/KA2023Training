using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign2
{
    internal class TotalPosition
    {
        private int switches;
        public TotalPosition(int switches) 
        {
            this.Switches = switches;
        }

        public int Switches { get => switches; set => switches = value; }

        public int tot()
        {
            int ans = (int)Math.Pow(2,this.Switches);
            return ans;
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter no of switches");
            int switches = Convert.ToInt32(Console.ReadLine());
            TotalPosition totalPosition = new TotalPosition(switches);
            int ans=totalPosition.tot();
            Console.WriteLine("No of Possible Positions:"+ans);
        }
    }
}
