using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interface_Polymorphism.Logger;

namespace Interface_Polymorphism {
    class Log {
        private List<ILogger> listeners;

        public Log() {
            listeners = new List<ILogger>();
        }

        public void RegisterLogger(ILogger logger) {
            listeners.Add(logger);
        }

        public void Logging(string evnt) {
            foreach(var logger in listeners) {
                logger.handleEvent(evnt);
            }
        }
    }
}


