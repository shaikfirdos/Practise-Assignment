using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class IdInfo
    {
        public int IdNumber;
        public IdInfo(int IdNumber)
        {
            this.IdNumber = IdNumber;
        }
    }
    public class Person
    {
        public int Age;
        public IdInfo IdInfo;
        public Person ShallowCopy()
        {
            return (Person)MemberwiseClone();
        }
        public Person DeepCopy()
        {
            Person other = (Person)this.MemberwiseClone();
            other.IdInfo = new IdInfo (IdInfo.IdNumber);
            return other;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Create an instance of person and assign values to it fields
            Person p1 = new Person();
            p1.Age = 22;
            p1.IdInfo = new IdInfo(3242);
            //perfoem a shallow copy of p1 and assign it to p2
            Person p2 = p1.ShallowCopy();
            //Display Values of p1 & p2
            Console.WriteLine("Original values of p1 & p2");
            Console.WriteLine(" p1 instance values: ");
            DisplayValues(p1);
            Console.WriteLine(" p2 instance values: ");
            DisplayValues(p2);

            p1.Age =25;
            p1.IdInfo = new IdInfo(1121);
           //Display Values of p1 & p2
            Console.WriteLine("\nValues of p1 & p2 after changed to p1:");
            Console.WriteLine(" p1 instance values: ");
            DisplayValues(p1);
            Console.WriteLine(" p2 instance values: ");
            DisplayValues(p2);

            Person p3 = p1.DeepCopy();
            p1.Age = 28;
            p1.IdInfo = new IdInfo(1234);
            //Display Values of p1 & p2
            Console.WriteLine("values of p1 & p3 after changes to p1:");
            Console.WriteLine(" p1 instance values: ");
            DisplayValues(p1);
            Console.WriteLine(" p2 instance values: ");
            DisplayValues(p3);
            Console.ReadKey();
        }
        public static void DisplayValues(Person p)
        {
            Console.WriteLine($" Age:{p.Age}");
            Console.WriteLine("  value:{0:d}", p.IdInfo.IdNumber);
        }
    }
  
}
