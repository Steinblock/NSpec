﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NSpec.Interpreter.Indexer
{
    public delegate void before<T>(T me) where T : class, new();
}
