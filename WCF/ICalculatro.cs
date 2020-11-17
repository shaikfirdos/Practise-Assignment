using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Creaate
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ICalculator" in both code and config file together.
    public class ICalculator : IICalculator
    {
       public int Sum(int num1,int num2)
        {
            return num1 + num2;
        }

        public int Subtract(int num1, int num2)
        {
            if(num1>num2)
            {
                return num1 - num2;
            }
            else
           
                return 0;
           
           
        }

        public int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        public int Division(int num1, int num2)
        {
            if (num2 != 0)
            {
                return num1 / num2;
            }
            else
                return 0;
           
        }
    }
}
