using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YieldDemo {
    class Program {
        static List<int> l1 = new List<int>();
        static void FillValues() {
            l1.Add(1);
            l1.Add(2);
            l1.Add(3);
            l1.Add(4);
            l1.Add(5);
        }

        static IEnumerable<int> Filter1() {
            List<int> tmp = new List<int>();
            foreach (int c in l1) {
                if (c > 3) {
                    tmp.Add(c);
                }
            }
            return tmp;
        }

        //example of custom iteration
        //filter without a tmp collection
        static IEnumerable<int> Filter() {
            foreach(int c in l1) {
                if(c > 3) {
                    yield return c;
                }
            }
        }


        //example of stateful iteration
        //the original value set: [1,2,3,4,5]
        //then the running total set: [1,3,6,10,15]
        static IEnumerable<int> RunningTotal() {
            int total = 0;
            foreach(int c in l1) {
                total += c;
                yield return total;
            }
        }

        


        static void Main(string[] args) {
            FillValues();
            foreach(var i in Filter()) {
                Console.WriteLine(i);
            }

            Console.WriteLine("\n");
            foreach (var i in RunningTotal()) {
                Console.WriteLine(i);
            }
        }
    }
}
