﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TR.Computation.Interface;

namespace TR.Computation.Imp
{
    public class AddTwo : ICompute
    {
        public void Compute(int input)
        {
            var result = input + 2;
            if (CallBack != null)
                CallBack("AddTwo", result);
        }

        public Action<string, int> CallBack { get; set; }
    }
}
