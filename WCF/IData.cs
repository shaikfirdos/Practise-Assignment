using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceLibrary2_assignment
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IData" in both code and config file together.
    [ServiceContract]
    public interface IData
    {
        [OperationContract]
        string relation1(int n1, int n2);//Greater than

        [OperationContract]
        string relation2(string n1, string n2);//Equal to

        [OperationContract]
        string relation3(string n1);//String length

        [OperationContract]
        string relation4(int n1, int n2);//Greater than equal to

    }
}
