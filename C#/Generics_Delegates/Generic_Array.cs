using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_Delegates
{
    internal class Generic_Array<T>
    {
       
        // ARRAY
        public T[] arr;
        public Generic_Array(int size)
        {
            arr = new T[size];
        }
        //SETTING VALUES
        public void setarr(int index,T value) 
        {
            arr[index] = value;
        }
        //RETURNING A VALUE
        public T OutArr(int index)
        {
            return arr[index];
        }
    }
}
