using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrinciple.Abstraction
{
    public class PayPalPaymentWithDiscount:PayPalPayment
    {
        private readonly decimal discount;
        public PayPalPaymentWithDiscount(decimal discount)
        {
            this.discount = discount;
        }

        public override void ProcessPayment(decimal amount)
        {
            base.ProcessPayment(amount-discount);
        }
    }
}
