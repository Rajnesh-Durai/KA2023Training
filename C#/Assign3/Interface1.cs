using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign3
{
    internal interface Interface1
    {
        public string progress();
    }
    internal class UIProgress:Interface1
    {
        public string progress()
        {
            return "Completed UI";
        }
    }
    internal class DBProgress : Interface1
    {
        public string progress()
        {
            return "Completed DB";
        }
    }
}
