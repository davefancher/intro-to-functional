using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntoToFunctionalExamples
{
    public class FunctionsAsDataExample
    {
        private static int AddNumber(int val1, int val2) => val1 + val2;

        private static int MulNumber(int val1, int val2) => val1 * val2;

        private static int changeValue(Func<int, int, int> function, int value, int value2) =>
            function(value, value2);

        private static Func<int, int, int> PickFunction(bool add) 
        {
            if (add)
            {
                return AddNumber;
            }
            return MulNumber;
        }

        public static void HigherOrderFunctionExample()
        {
            Console.WriteLine("2 and three added are: " 
                + changeValue(AddNumber, 2, 3));

            Console.WriteLine("2 and 3 multipled are: " 
                + changeValue(MulNumber, 2, 3));

            var fun = PickFunction(false);

            Console.WriteLine("2 and three added are: " 
                + changeValue(fun, 2, 3));
        }
    }
}
