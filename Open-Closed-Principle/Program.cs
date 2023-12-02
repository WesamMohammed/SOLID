// See https://aka.ms/new-console-template for more information
using OpenClosedPrinciple;
using OpenClosedPrinciple.Abstraction;

Console.WriteLine("Hello, World!");


var payment1 = new PaymentHandler(new PayPalPayment());
payment1.Pay(new decimal(300.03));
var payment2 = new PaymentHandler(new CreditCardPayment());
payment2.Pay(new decimal(400.03));

new PaymentHandler(new PayPalPaymentWithDiscount(10)).Pay(100);
