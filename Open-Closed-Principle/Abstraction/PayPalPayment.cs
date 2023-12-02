using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrinciple.Abstraction
{
    public class PayPalPayment : IPaymentStratigy
    {
       virtual public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"this is the payment using PayPal amount:{amount}");
        }
    }
}
