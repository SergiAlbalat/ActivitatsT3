using System;
namespace ActivitatsT3
{
    public class PaymentCard
    {
        public double Balance { get; set; }
        public PaymentCard(double startingBalance)
        {
            Balance = startingBalance;
        }
        public override string ToString() => $"The card has a balance of {Balance} euros";
    }
}