using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace IntoToFunctionalExamples
{
    public class FunctionalPurity
    {
        public int i { get; set; }

        public int addOneToI()
        {
            Console.WriteLine("The input is: " + i);

            i = i + 1;

            Console.WriteLine("The output is: " + i);

            return i;
        }

        public static int addOne(int num)
        {
            Console.WriteLine("The input is: " + num);

            var j = num + 1;

            Console.WriteLine("The output is: " + j);

            return j;
        }
    }
}



namespace example
{ 
    class FunctionalPurityDemo
    { 


        /////////////////////////////////////////////////////////////////////
        //  DemoFunctionalPurity
        ////////////////////////////////////////////////////////////////////

        public static void DemoFunctionalPurity()
        {
            var demoObject = new IntoToFunctionalExamples.FunctionalPurity
            {
                i = 1
            };


            for(int j=1; j <= 5; j++)
            {
                demoObject.i = 1;

                new Thread(
                    () => demoObject.i = demoObject.i + 5)
                    .Start();

                demoObject.addOneToI();

                Console.WriteLine("");
            }

            Console.WriteLine("\nPure Function\n");


            for (int j = 1; j <= 5; j++)
            {
                demoObject.i = 1;

                new Thread(
                    () => demoObject.i = demoObject.i + 5)
                    .Start();

                IntoToFunctionalExamples.FunctionalPurity.addOne(demoObject.i);

                Console.WriteLine("");
            }
        }

    }
}
