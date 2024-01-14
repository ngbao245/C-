using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.LambdaExpression
{
    public static class Lambda
    {
        public static void LambdaFunction1()
        {
            var lambda = () =>
            {
                Console.WriteLine("Ex1: This is lambda expression");
            };
            lambda();
        }

        public static void LambdaFunction2()
        {
            Func<string, string> lambda = (string name) =>
            {
                Console.WriteLine($"Ex2: My name is {name}.");
                return name;
            };
            string name = lambda("BaoBiBo");
            Console.WriteLine($"name = {name}");
        }

        public static void LambdaSyntax()
        {
            int count = 1;
            // 1. The data type of the input parameter can be ignored
            Action<string> type1 = (input) => { Console.WriteLine($"{count++}. Parameter value is: {input}"); };

            // 2. If there is no parameter, leave the () blank
            var type2 = () => { Console.WriteLine($"{count++}. There is no parameter"); };

            // 3. If there is only 1 parameter, you can remove the () mark.
            Action<string> type3 = oneParameter => { Console.WriteLine($"{count++}. There is only 1 parameter: {oneParameter}"); };

            // 4. If there are multiple parameters, separate them with commas
            Action<string, string> type4 = (a, b) => { Console.WriteLine($"{count++}. Hello {a}{b}"); };

            // 5. If the anonymous function has only 1 statement, you can omit the {}
            var type5 = (string name) => Console.WriteLine($"{count++}. Hello {name}");

            // 6. If you only return 1 value, you no need to return
            Predicate<string> type6 = (value) => value.ToLower().Contains("a");
            
            type1("example1");
            type2();
            type3("example3");
            type4("example", "4");
            type5("example5");
            if (type6("example6"))
            {
                Console.WriteLine($"{count++}. {true}");
            }

            // These are the same
            Predicate<int> equivalent1 = delegate (int x)    { return x > 4; };
            Predicate<int> equivalent2 =          (int x) => { return x > 4; };
            Predicate<int> equivalent3 =          (int x) =>          x > 4; 
            Predicate<int> equivalent4 =              (x) =>          x > 4;
            Predicate<int> equivalent5 =               x  =>          x > 4;
        }
    }
}
