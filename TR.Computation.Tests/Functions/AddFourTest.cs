using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using TR.Computation.Functions;

namespace TR.Computation.Tests.Functions
{
    [TestClass]
    public class AddFourTest
    {
        [TestMethod]
        public void should_execute_compute_first_then_call_callback_action()
        {
            string name = string.Empty;
            int result = 0;
            var add = new AddFour();

            add.Execute(0, (n, r) => { name = n; result = r; });

            Assert.AreNotEqual(string.Empty, name);
            Assert.AreNotEqual(0, result);
            Assert.AreEqual(FunctionNames.ADD_FOUR, name);
            Assert.AreEqual(4, result);
        }
    }
}
