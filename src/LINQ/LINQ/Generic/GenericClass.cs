using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.Generic
{
    public class GenericClass<T>
    {
        public T Value { get; set; }

        public GenericClass(T t)
        {
            Value = t;
        }

        public void PrintValue()
        {
            Console.WriteLine($"{Value}");
        }
    }
}
