﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Polymorphism.Logger {
    class ConsoleLogger : ILogger {
        public void handleEvent(string evnt) {
            Console.WriteLine(evnt);
        }
    }
}


