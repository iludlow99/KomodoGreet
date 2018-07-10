﻿using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoGreet.UI
{
    class RealConsole : IConsole
    {
        [ExcludeFromCodeCoverage]
        public class RealConsole : IConsole
        {
            public void WriteLine(string message)
            {
                Console.WriteLine(message);
            }
            public void Write(string message)
            {
                Console.Write(message);
            }
            public string ReadLine()
            {
                return Console.ReadLine();
            }
            public void WriteLine(Object o)
            {
                Console.WriteLine(o.ToString());
            }

        }
    }
}
