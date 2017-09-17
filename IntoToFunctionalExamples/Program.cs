using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntoToFunctionalExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            //DemoFunctionalPurity();
            //TamingSideEffectsExample();
            //FunctionsAsDataDemo();
            //LambdaFunctionDemo();
            //LinqSample();
            Console.ReadLine();
        }

        static void DemoFunctionalPurity()
        {
            example.FunctionalPurityDemo.DemoFunctionalPurity();
        }

        static void FunctionsAsDataDemo()
        {
            FunctionsAsDataExample.HigherOrderFunctionExample();
        }

        static void TamingSideEffectsExample()
        {
            new TamingSideEffects(Console.WriteLine, "Hello World!").Write();

            TamingSideEffects.sendStringToActionStatically("Hello World!", Console.WriteLine);
        }

        static void LambdaFunctionDemo()
        {
            Func<int,int> func = num => num + 1;
            Console.WriteLine(
                new LambdaFunctionsExample(func)
                .RunFunction(5));


            Console.WriteLine(
                new LambdaFunctionsExample(num => num + 1)
                .RunFunction(5));
        }

        static void LinqSample()
        {
            var array =new[] { 1, 3, 5, 7, 9 };
            Func<string, string, string> aggregateFunction = (first, second) => first + ", " + second;

            var changedArray = LinqExamples.LinqExample(array)
                .Aggregate(aggregateFunction);


            Console.WriteLine(changedArray);
        }
    }
}
