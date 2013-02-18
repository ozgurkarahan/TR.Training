using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using TR.Computation.Functions;

namespace TR.Computation.Tests.Functions
{
    [TestClass]
    public class AddFiveTest
    {
        [TestMethod]
        public void ComputeTest()
        {
            var add = new AddFive();

            var result = add.Compute(0);

            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void FunctionNameTest() 
        {
            var add = new AddFive();

            var name = add.FuncionName;

            Assert.AreEqual(FunctionNames.ADD_FIVE, name);
        }

        [TestMethod]
        public void should_execute_compute_first_then_call_callback_action()
        {
            string name = string.Empty;
            int result = 0;
            var add = new AddFive();

            add.Execute(0, (n, r) => { name = n; result = r; });

            Assert.AreNotEqual(string.Empty, name);
            Assert.AreNotEqual(0, result);
            Assert.AreEqual(FunctionNames.ADD_FIVE, name);
            Assert.AreEqual(5, result);
        }
    }
}
