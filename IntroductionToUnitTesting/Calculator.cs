﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionToUnitTesting
{
    public class Calculator
    {
        public int Add(int x, int y)
        {
            int result = x + y;
            return result;
        }

        public int Subtract(int x, int y)
        {
            int result = x - y;
            return result;
        }

        public int Multiply(int x, int y)
        {
            return x * y;
        }
    }
}
