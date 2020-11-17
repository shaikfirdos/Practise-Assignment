using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceLibrary2
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService2" in both code and config file together.
    [ServiceContract]
    public interface IService2
    {
        [OperationContract]
        string palindrome(string S1, string rev);

        //[OperationContract]
        //string DARLING(string S1, int y);

        [OperationContract]
        string dat1(int y);

        
    }
}
