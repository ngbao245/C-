using LINQ.ExtensionMethod;
using LINQ.CallbackDelegate;
using LINQ.LambdaExpression;
using LINQ.Generic;


namespace LINQ
{
    public static class Test
    {
        // Extension Method
        public static void ExtensionMethod()
        {
            // Without Extension Method
            Student John = new Student
            {
                Name = "John",
                Age = 10,
            };

            John.SayHello();
            //John.PrintInfo(); Error if Without Extension Method

            Student Unknown = new Student();
            Unknown.SayHello();

            // With Extension Method
            Student JohnExtensionMethod = new Student
            {
                Name = "John",
                Age = 10,
            };
            JohnExtensionMethod.PrintInfo();
        }

        // Callback & Delegate
        public static void Delegate1()
        {
            CallbackDelegate.CallbackDelegate delegateTimer = new CallbackDelegate.CallbackDelegate(3, CallbackDelegate.CallbackDelegate.Message);
            delegateTimer.Start();
        }

        public static void Delegate2()
        {
            CallbackDelegate.CallbackDelegate.Display(CallbackDelegate.CallbackDelegate.Donate);
        }

        public static void Action()
        {
            //CallbackAction action = new CallbackAction();
            CallbackAction.PayMoney(1000, CallbackAction.GetIphone);
        }

        public static void Predicate()
        {
            //CallbackPredicate predicate = new CallbackPredicate();
            CallbackPredicate.Gift("Flower", CallbackPredicate.HaveFlower);
        }

        public static void Func()
        {
            //CallbackFunc func = new CallbackFunc();
            CallbackFunc.BuyFood("Pizza", CallbackFunc.Cashier);
        }

        // Anonymous Method & Lambda Expression
        public static void AnonymousMethod1()
        {
            AnonymousMethod.PrintBill1();
        }

        public static void AnonymousMethod2()
        {
            AnonymousMethod.PrintBill2();
        }

        public static void LambdaMethod1()
        {
            Lambda.LambdaFunction1();
        }
        public static void LambdaMethod2()
        {
            Lambda.LambdaFunction2();
        }
        public static void LambdaSyntax()
        {
            Lambda.LambdaSyntax();
        }

        // Generic Type
        public static void GenericFunction()
        {
            List<int> intList = Enumerable.Range(0, 10).ToList();
            List<double> doubleList = Enumerable.Range(1, 9).Select(i => i * 0.1).ToList();
            List<string> stringList = Enumerable.Range('A', 26).Select(x => ((char)x).ToString()).ToList();

            int[] intArray = Enumerable.Range(0, 10).ToArray();
            double[] doubleArray = Enumerable.Range(1, 9).Select(i => i * 0.1).ToArray();
            string[] alphabetArray = Enumerable.Range('A', 26).Select(x => ((char)x).ToString()).ToArray();


            Console.WriteLine("Ex1: GetRandomElementFromList: " + stringList.GetRandomElementFromList());

            Console.Write("Ex2: GenerateString: ");
            foreach (var item in alphabetArray.GenerateString(10))
            {
                Console.Write(item);
            }
            Console.WriteLine();

            Console.Write("Ex3: GetWaitingNumber: ");
            foreach (var item in intList.GetWaitingNumber(5))
            {
                Console.Write(item);
            }
        }

        public static void CreateGenericClass()
        {
            GenericClass<int> generic = new GenericClass<int>(1);
            generic.PrintValue();
        }
    }
}
