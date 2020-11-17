using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceLibrary1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service1 : IService1
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        public  string Hello (string name)
        {
            return string.Format("Hello : {0}", name);
        }

        public string Example(string n1, string n2)
        {
            return string.Format("hai : {0} this is {1}", n1, n2);
        }

        public string Example1(string name, int age)
        {
            return string.Format("hai : {0} , You entered age : {1}", name, age);
        }

        public string GetData1(int value1)
        {
            return string.Format("Example {0}",value1);
        }

    }
}
