using FirstLab.algorithms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstLab.tests
{
    internal class Tests
    {
        public bool runTestOne()
        {

            Algorithms algorithms = new Algorithms();

            const int x1 = 1;
            const int y1 = 2;

            const int x2 = 3;
            const int y2 = 4;

            const int x3 = 5;
            const int y3 = 6;

            const int x4 = 7;
            const int y4 = 8;

            if(algorithms.outputResultForTests(x1, y1, x2, y2, x3, y3, x4, y4))
            {
                return true;    
            } else { 
                return false; 
            }
        }

        public bool runTestTwo()
        {

            Algorithms algorithms = new Algorithms();

            const int x1 = 1;
            const int y1 = 2;

            const int x2 = 3;
            const int y2 = 4;

            const int x3 = 5;
            const int y3 = 6;

            const int x4 = 7;
            const int y4 = 8;

            if (algorithms.outputResultForTests(x1, y1, x2, y2, x3, y3, x4, y4))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool runTestThree()
        {

            Algorithms algorithms = new Algorithms();

            const int x1 = 1;
            const int y1 = 2;

            const int x2 = 3;
            const int y2 = 4;

            const int x3 = 5;
            const int y3 = 6;

            const int x4 = 7;
            const int y4 = 8;

            if (algorithms.outputResultForTests(x1, y1, x2, y2, x3, y3, x4, y4))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void runAllTests()
        {
            Tests tests = new Tests();
            Console.Write("================= Модульные тесты ==============");
            if(tests.runTestOne() && tests.runTestTwo() && tests.runTestThree())
            {
                Console.WriteLine("\n[!]Модульные тесты успешно пройдены");
            } else {
                Console.WriteLine("\n[!]Модульные тесты не пройдены :(");
            }
            Console.WriteLine("================================================");
        }
    }
}
