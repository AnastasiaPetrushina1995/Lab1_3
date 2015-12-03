using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
   public class Hours : ISalaryCalculator
   {
       private int _hour;
       private int _hourInMounth;

       public Hours(int hour, int hourInMounth)
       {
           if ((hour <= 0) || (hourInMounth <= 0) )
           {
               throw new MoneyExeption("Количество часов не может быть меньше 0!");
           }
           _hour = hour;
           _hourInMounth = hourInMounth;
       }
       public double Calculate()
       {
           return _hour * _hourInMounth;
       }
    }
}
