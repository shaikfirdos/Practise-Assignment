using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceLibrary2
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service2" in both code and config file together.
    public class Service2 : IService2
    {
        public string palindrome(string S1, string rev)
        {
           for(int i = S1.Length-1;i>=0;i--)
            {
                rev += S1[i];
            }
           if(S1==rev)
            {
                return "palindrome";
            }
           else
            {
                return "not PALINDROME";
            }
        }
        //public string DARLING(string S1, int y)
        //{
        //    for (int x = 1 ; x <= y; x++)
        //    {
        //        return (S1 );
        //    }
        //    return S1;
        //}

       public string dat1(int y)
        {
            if (y%2 == 0)
            {
                return "even";
            }
            else
                return "odd";
        }
      

    }
}
