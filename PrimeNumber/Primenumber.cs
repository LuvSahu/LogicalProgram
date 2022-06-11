using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProblem
{
    internal class Primenumber
    {
            public void stopwatchprg()
            {
                Console.WriteLine("Press Enter to start");
                Console.ReadLine();

                DateTime Start = DateTime.Now;

                Console.WriteLine("Press Enter to stop");
                Console.ReadLine();

                DateTime Stop = DateTime.Now;
                Console.WriteLine("Elapsed Time = " + (Stop - Start));

            }
        }
    }

