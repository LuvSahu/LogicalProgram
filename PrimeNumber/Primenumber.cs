﻿using System;
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
                  int n, i, m=0, flag=0;    
                  Console.Write("Enter the Number to check Prime: ");    
                  n = int.Parse(Console.ReadLine());  
                  m=n/2;    
                  for(i = 2; i <= m; i++)    
                  {    
                   if(n % i == 0)    
                    {    
                     Console.Write("Number is not Prime.");    
                     flag=1;    
                     break;    
                    }    
                  }    
                  if (flag==0)    
                   Console.Write("Number is Prime."); 

            }
        }
    }

