using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceLibrary2_assignment
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Data" in both code and config file together.
    public class Data : IData
    {
        public string relation1(int n1, int n2)
        {
            if (n1 > n2)
            {
                return string.Format("{0} is greater than {1}", n1, n2);
            }
            else

                return string.Format("{0} is less than {1}", n1, n2);


        }

        public string relation2(string n1, string n2)
        {
            if (n1 == n2)
            {
                return string.Format("{0} is equal {1}", n1, n2);
            }
            else

                return string.Format("{0} is not equal {1}", n1, n2);


        }

        public string relation3(string n1)
        {
            if(n1.Length<=3)
            {
                return string.Format("Given string length is correct {0}", n1);
            }
            else
                return string.Format("Given string length is  not correct {0}", n1);
        }

        public string relation4(int n1, int n2)
        {
            if (n1 > n2)
            {
                return string.Format("{0} is greater than equal to {1}", n1, n2);
            }
            else

                return string.Format("{0} is less than equal to {1}", n1, n2);

        }


    }
}
