﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core;

namespace GUI
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {

            /*Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new HeadForm()); */
            try
            {
                List <ISalaryCalculator> Salary = new List<ISalaryCalculator>(); // комментарий 
                Salary.Add(new Hours(2, 4));
                Salary.Add(new Month(2, -4, 6));
                Salary.Add(new Rate(5, 2));
                foreach (ISalaryCalculator fig in Salary)
                {
                    Console.WriteLine(fig.Calculate());
                }
            }
             catch (MoneyExeption)
            {
                System.Console.WriteLine("yt");
            }
            System.Console.ReadLine();
            
        } 
    }
}
