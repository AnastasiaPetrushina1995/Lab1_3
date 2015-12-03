using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class MoneyExeption : System.Exception
    {
         public MoneyExeption(string message) : base(message)
        {
        }
    }
}