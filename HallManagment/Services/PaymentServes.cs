using HallManagment.Entities;

namespace HallManagment.Services
{
    public class PaymentServes
    {
        private List<Payment> payments = new List<Payment>();

        public List<Payment> GetPayments()
        {
            return payments;
        }
        public Payment? GetPaymentById(int id)
        {
            return payments.Find(p => p.Id == id);
        }

        public void AddPayment(Payment payment)
        {
            payments.Add(payment);
        }

        public void RemovePayment(int id)
        {
            int index = payments.FindIndex(p => p.Id == id);
            if (index != -1)
                payments.RemoveAt(index);
        }

        public void UpdatePayment(int id, Payment payment)
        {
            int index = payments.FindIndex(p => p.Id == id);
            if (index != -1)
                payments[index] = payment;
        }
    }
}
