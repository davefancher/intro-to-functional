using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntoToFunctionalExamples
{
    public class LinqExamples
    {
        public static IEnumerable<string> LinqExample(IEnumerable<int> array) =>
            array
            .Where(i => i > 5)
            .Select(i => i.ToString());
    }
}
