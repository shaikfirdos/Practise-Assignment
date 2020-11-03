using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)//Client Method
        {
            Payment order = new CardPayment();
            order._IpaymentSystem = new CitiPaymentSystem();
            order.MakePayment();
           
            order._IpaymentSystem = new IDBIPaymentSystem();
            order.MakePayment();

            order = new NetBanking();
            order._IpaymentSystem = new CitiPaymentSystem();
            order.MakePayment();

            Console.ReadKey();

        }

        public interface IPaymentSystem//Implementer Interface
        {
            void ProcessPayment(string paymentSystem);
        }

        public class CitiPaymentSystem : IPaymentSystem//Concrete Implementor
        {
            public void ProcessPayment(string paymentSystem)
            {
                Console.WriteLine("Using Citibank for " + paymentSystem);
            }
        }

        public class IDBIPaymentSystem : IPaymentSystem //Concrete Implementor
        {
            public void ProcessPayment(string paymentSystem)
            {
                Console.WriteLine("Using IDBI for " + paymentSystem);
            }
        }
        public abstract class Payment//abstract class
        {
            public IPaymentSystem _IpaymentSystem;
            public abstract void MakePayment();
        }

        public class CardPayment:Payment//refinedAbstraction
        {
            public override void MakePayment()
            {
                _IpaymentSystem.ProcessPayment("Card Payment");
            }
        }
        public class NetBanking : Payment//RefinedAbstraction
        {
            public override void MakePayment()
            {
                _IpaymentSystem.ProcessPayment("NetBanking Payment");
            }
        }
    }
}
