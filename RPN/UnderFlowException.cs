﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPN
{
    public class UnderflowException : Exception
    {
        public UnderflowException(string message) : base(message)
        {
        }
    }
}
