using OpenClosedPrinciple.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrinciple
{
    public class PaymentHandler
    {
        private readonly IPaymentStratigy _payment;

        public PaymentHandler(IPaymentStratigy payment) {
            _payment = payment;
        }

        public void Pay(decimal amount)
        {
            _payment.ProcessPayment(amount);
        }
    }
}
