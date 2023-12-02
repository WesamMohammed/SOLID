using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrinciple.Abstraction
{
    public class CreditCardPayment : IPaymentStratigy
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"this is the payment using creditCard amount:{amount}");
        }
    }
}
