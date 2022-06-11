using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProblem
{
    internal class Perfectnumber
    {
            public bool Factors(int Number, int Potential_Factor)
            {
                if (Number % Potential_Factor == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            public void Perfectnum()
            {
                int check = 0;
                Console.Write("Enter the number: ");
                int number = Convert.ToInt32(Console.ReadLine());
                for (int i = 1; i < number/2; i++)
                {
                    if (Factors(number, i))
                    {
                        check += i;
                    }
                }

                if (check == number)
                {
                    Console.WriteLine(number + "is a Perfect Number.");
                }
                else
                {
                    Console.WriteLine(number + "is not a Perfect Number.");
                }
            }
        }
    }

