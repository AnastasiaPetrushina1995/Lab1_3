using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
   public class Month : ISalaryCalculator
    {
        private int _salaryInMounth;
        private int _neededHours;
        private int _workedHours;

        public Month(int salaryInMounth, int neededHours, int workedHours)
        {
            if ((salaryInMounth <= 0) || (neededHours <= 0) || (workedHours <= 0))
            {
                throw new MoneyExeption("Количество месяцев не может быть меньше 0!");
            }
           _salaryInMounth = salaryInMounth;
           _neededHours = neededHours;
           _workedHours = workedHours;
        }
        public double Calculate()
        {
            return _salaryInMounth * _workedHours / _neededHours;
        }
    }
}
