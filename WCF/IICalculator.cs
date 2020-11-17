using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Creaate
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IICalculator" in both code and config file together.
    [ServiceContract]
    public interface IICalculator
    {
        [OperationContract]
        //void DoWork();
        int Sum(int num1, int num2);//Addition

        [OperationContract]
        int Subtract(int num1, int num2);//Subtraction

        [OperationContract]
        int Multiply(int num1, int num2);//Multiplication

        [OperationContract]
        int Division(int num1, int num2);//Division

    }
}

//use a data contract to composite types to services operations

    [DataContract]//Declared and assign the variables
    public class  CompositeType
  {
    bool boolvalue = true;//Boolean variable assigned true
    string stringValue = "Hello World";//string variable returning "Hello World"

    [DataMember]//you will call or invoke the data information
    public bool BoolValue
    {
        get { return boolvalue; }
        set { boolvalue = value; }
    }

    [DataMember]
    public string StringValue
    {
        get { return stringValue; }
        set { stringValue = value; }
    }
}