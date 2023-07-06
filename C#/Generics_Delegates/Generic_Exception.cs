using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_Delegates
{
    internal class Generic_Exception<T> where T : Exception
    {
        private T excep_obj;
        public Generic_Exception(T excep_obj)
        {
            this.excep_obj = excep_obj;
        }
        public T Display() { return excep_obj; }
    }
}
