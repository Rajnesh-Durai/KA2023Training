using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArray
{
    internal class Lambda
    {
        public void evennum()
        {
            List<int> list = new List<int>() { 5, 8, 1, 2, 4, 3, 71 };
            List<int> even = list.FindAll(x => ((x % 2) == 0));
            list.Select(x => ((x % 2) == 0));
            foreach (int ans in even)
            {
                Console.WriteLine(ans);
            }

        }
        
        
    }
    internal abstract class assum
    {
        public virtual void disp()
        {
            Console.WriteLine("sent 1");
        }
        public  abstract void dog();
    }
    internal class ans:assum
    {
        public override void disp()
        {
            base.disp();
            Console.WriteLine("sent2");
        }
        public override void dog()
        {
            Console.WriteLine("hello");
        }
    }
}
