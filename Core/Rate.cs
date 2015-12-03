using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class Rate : ISalaryCalculator 
    {
       private int _salaryInYear;
       private int _workedMonth;
      
       public Rate(int salaryInYear, int workedMonth)
       {
           if ((salaryInYear <= 0) || (workedMonth <= 0))
           {
               throw new MoneyExeption("Не может быть меньше 0!");
           }
           _salaryInYear = salaryInYear;
           _workedMonth = workedMonth;
       }
        public double Calculate()
        {
            return _salaryInYear / 12.0 * _workedMonth; 
        }
    }
}
