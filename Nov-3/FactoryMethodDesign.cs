using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter your object type");
            var x = Console.ReadLine();
            I1 obj = CreateObj.getObject(x);
            Console.WriteLine(obj.getID());
            Console.WriteLine(obj.getName());
            Console.ReadKey();

        }
    }
     class CreateObj//Factory Class: Creating instantiation without given logic to the main method or Client
    {
        public static I1 getObject(string f)
        {
            I1 obj = null;
            if(f== "EmployeeDetails")
            {
                obj = new EmployeeDetails();
            }
            else
            {
                obj = new ClientDetails();
            }
            return obj;
        }
    }
    interface I1//Declaration
    {
        string getID();
        string getName();
    }
    class EmployeeDetails: I1 //interface definition
    {
        public string getID()
        {
            return "EmployeeID:121323";
        }

        public string getName()
        {
            return "EmployeeName:Muntaj";
        }
    }

    class  ClientDetails:I1//interface definiton
    {
        public string getID()
        {
            return "ClientName:Hemakumar";
        }

        public string getName()
        {
            return "ClientProject:OnlineLibraray";
        }
    }

}
