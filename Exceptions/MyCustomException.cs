﻿using System;

namespace Exceptions
{
    public class MyCustomException: ApplicationException
    {
        public MyCustomException(string message) : base(message)
        { }

    }
}
