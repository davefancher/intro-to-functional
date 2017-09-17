using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using IntoToFunctionalExamples;

namespace NaturalInterface
{
    [TestClass]
    public class NaturalInterface
    {
        [TestMethod]
        public void PassesHelloWorld()
        {
            new TamingSideEffects(
                str => Assert.AreEqual("Hello World!", str),
                "Hello World!")
                .Write();
        }

        [TestMethod]
        public void PassesHelloWorldStatic()
        {
            TamingSideEffects.sendStringToActionStatically(
                "Hello World!", 
                str => Assert.AreEqual("Hello World!", str));
        }

    }
}
