using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntoToFunctionalExamples
{
    public class LambdaFunctionsExample
    {
        public Func<int, int> lambda { get; }

        public LambdaFunctionsExample(Func<int, int> function)
        {
            lambda = function;
        }

        public int RunFunction(int num)
        {
            return lambda(num);
        }
    }
    
}
