using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntoToFunctionalExamples
{
    public class TamingSideEffects
    {
        public TamingSideEffects(Action<string> outFunc, string str)
        {
            outputMethod = outFunc;
            strng = str;
        }


        private Action<string> outputMethod;

        private string strng;

        public void Write()
        {
            outputMethod(strng);
        }


        public static void sendStringToActionStatically(string val, Action<string> act)
        {
            act(val);
        }
    }
}
