using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Interface_Polymorphism.Logger {
    class FileLogger : ILogger {
        public void handleEvent(string evnt) {
            //method 1
            //StreamWriter sw = new StreamWriter(@"../../Logger/LogFile.txt");
            //sw.WriteLine(evnt);
            //sw.Close();
            //write to file (method 2)
            using (StreamWriter sw = new StreamWriter(@"../../Logger/LogFile.txt")) {
                sw.WriteLine(evnt);
                sw.Close();
            }
        }
    }
}





