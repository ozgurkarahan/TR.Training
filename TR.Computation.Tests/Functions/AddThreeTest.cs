﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using TR.Computation.Functions;

namespace TR.Computation.Tests.Functions
{
    [TestClass]
    public class AddThreeTest
    {
        [TestMethod]
        public void ComputeTest()
        {
            var add = new AddThree();

            var result = add.Compute(0);

            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void FunctionNameTest()
        {
            var add = new AddThree();

            var name = add.FuncionName;

            Assert.AreEqual(FunctionNames.ADD_THREE, name);
        }

        [TestMethod]
        public void should_execute_compute_first_then_call_callback_action()
        {
            string name = string.Empty;
            int result = 0;
            var add = new AddThree();

            add.Execute(0, (n, r) => { name = n; result = r; });

            Assert.AreNotEqual(string.Empty, name);
            Assert.AreNotEqual(0, result);
            Assert.AreEqual(FunctionNames.ADD_THREE, name);
            Assert.AreEqual(3, result);
        }
    }
}
