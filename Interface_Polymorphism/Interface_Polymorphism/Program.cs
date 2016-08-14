using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interface_Polymorphism.Logger;

namespace Interface_Polymorphism {
    class Program {
        static void Main(string[] args) {
            Log log = new Log();
            FileLogger fileLogger = new FileLogger();
            ConsoleLogger consoleLogger = new ConsoleLogger();

            //register loggers
            log.RegisterLogger(consoleLogger);
            log.RegisterLogger(fileLogger);
            

            log.Logging("Hello world.");
            log.Logging("Hello Interface and Polymorphism");
        }
    }
}



