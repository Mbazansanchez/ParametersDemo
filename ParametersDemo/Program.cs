using System;

namespace ParametersDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int testValue1 = 1;
            Console.WriteLine("Original value: {0}", testValue1);
            Test(testValue1);
            Console.WriteLine("Returned value: {0}\n", testValue1);

            int testVal2;
            //Console.WriteLine("\nOriginal value: {0}", testVal2);
            TestOut(out testVal2);
            Console.WriteLine("Returned value: {0}", testVal2);

            int testVal3 = 3;
            Console.WriteLine("\nOriginal value: {0}", testVal3);
            TestRef(ref testVal3);
            Console.WriteLine("Returned value: {0}", testVal3);

            Console.WriteLine("\nCalling TestOptional with no parameter.");
            TestOptional();
            /*Calling the TestOptional function will display 444, even though no variable was passed
            This is because aValue in the function is set to default to the value of 444.*/
            Console.WriteLine("\nCalling TestOptional");
            TestOptional(4);
            /*Here we pass in 4 and get 4 as the output because 4 is a value so 
             the output will not default to 444.*/

            Console.WriteLine("\nTestMultiple call all three set");
            TestMultiple(1, 2, 3);

            Console.WriteLine("\nMultipleTest call for only 2 parameters");
            TestMultiple(1, 2);
            //In the output the 3rd value becomes the default.

            Console.WriteLine("\nMultipleTest call for only 2 parameters");
            TestMultiple(1, cValue: 3);
            /*By calling the exact variable with a colon in the parameter 
             we can choose which parameter is set to the specified value.
            in this case the value is set to 3 on the cValue so the bValue
            will be set to the value of 222, which is its default value in the parameters.*/
        }

        public static void TestMultiple(int aValue, int bValue = 222, int cValue = 333)
        {
            
            Console.WriteLine("In TestMultiple Values are {0}, {1}, {2}", aValue,
                bValue, cValue);
        }


        public static void Test(int aValue)
        {
            aValue = 111;
            Console.WriteLine("In Test Value is {0}", aValue);
        }

        public static void TestOut(out int aValue)
        {
            aValue = 222;
            Console.WriteLine("In TestOut Value is {0}", aValue);
        }

        public static void TestRef(ref int aValue)
        {
            aValue = 333;
            Console.WriteLine("in TestRef value is {0}", aValue);

        }

        public static void TestOptional(int aValue = 444)
            /*By setting aValue to 444 it indicates that if a variable 
             that has no value is passed into the function, it will default
            to the value 444.*/
        {
            Console.WriteLine("Inside testOptional value is {0}", aValue);
        }
    }
}
