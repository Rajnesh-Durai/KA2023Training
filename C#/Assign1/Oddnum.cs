using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Assign1
{
    internal class Oddnum
    {
        public char elem1(string sentence)
        {
            int div=sentence.Length/2;
            
            return sentence[div];
        }
    }
    internal class Evennum
    {
        public char elem2(string sentence)
        {
            int count2 = (sentence.Length / 2) ;
            char ans = sentence[count2] ;
            return ans;
        }
        public char elem3(string sentence)
        {
            int count3 = (sentence.Length / 2)-1;
            char ans1 = sentence[count3];
            return ans1;
        }
    }
}
