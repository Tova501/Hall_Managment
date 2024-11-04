namespace HallManagment.Entities
{
    public enum PaymentMethod {CASH, CREDIT, CHECK, BANK_TRANSFER}
    public class Payment
    {
        public int Id { get; set; }
        public DateOnly Date {  get; set; }
        public int Price { get; set; }
        public int Discount { get; set; }
        public int FinalPrice { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public BankAccountDetails? BankAccountDetails { get; set; }

        public Payment() { }

        public Payment(int id, DateOnly date, int price, int discount, int finalPrice, PaymentMethod paymentMethod, BankAccountDetails? bankAccountDetails)
        {
            Id = id;
            Date = date;
            Price = price;
            Discount = discount;
            FinalPrice = finalPrice;
            PaymentMethod = paymentMethod;
            BankAccountDetails = bankAccountDetails;
        }
    }
}
