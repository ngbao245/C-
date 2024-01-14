using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.Generic
{
    public static class GenericFunction
    {
        public static T GetRandomElementFromList<T>(this List<T> list)
        {
            Random random = new Random();
            int randomElement = random.Next(list.Count);
            return list[randomElement];
        }

        public static T[] GenerateString<T>(this T[] array, int length)
        {
            T[] result = new T[length];
            Random random = new Random();
            for (int i = 0; i < length; i++)
            {
                result[i] = array[random.Next(array.Length)];
            }
            return result;
        }

        public static List<T> GetWaitingNumber<T>(this List<T> intList, int length)
        {
            List<T> waitingNumber = new List<T>();
            Random random = new Random();

            for (int i = 0; i < length; i++)
            {
                int index = random.Next(intList.Count() - 1);
                waitingNumber.Add(intList[index]);
            }
            return waitingNumber;
        }
    }
}
