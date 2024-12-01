using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hall.Core.Entities
{
    public enum PaymentMethod { CASH, CREDIT, CHECK, BANK_TRANSFER }

    public class Payment
    {
        private static int nextId = 1;

        public int Id { get; }
        public DateOnly Date { get; set; }
        public int Price { get; set; }
        public int Discount { get; set; }
        public int FinalPrice { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public BankAccountDetails? BankAccountDetails { get; set; }

        public Payment(DateOnly date, int price, int discount, int finalPrice, PaymentMethod paymentMethod, BankAccountDetails? bankAccountDetails)
        {
            Id = nextId;
            nextId++;

            Date = date;
            Price = price;
            Discount = discount;
            FinalPrice = finalPrice;
            PaymentMethod = paymentMethod;
            BankAccountDetails = bankAccountDetails;
        }
    }

}
