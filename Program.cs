﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int IS_FULL_TIME = 1;
            int EMP_RATE_PER_HR = 20;
            int empHrs = 0;
            int empWage = 0;
            Console.WriteLine("Welcome to EmployeeWage computation");

            Random random = new Random();
            int empCheck = random.Next(0, 2);
            if (empCheck == IS_FULL_TIME)
            {
                empHrs = 8;
            }
            else
            {
                empHrs = 0;
            }
            empWage = empHrs * EMP_RATE_PER_HR;
            Console.WriteLine("EMployee wage is:" + empWage);
        
        }
    }
}
