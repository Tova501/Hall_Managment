using HallManagment.Entities;
using Microsoft.Extensions.Logging;

namespace HallManagment.Services
{
    public class CustomerServes
    {
        private List<Customer> Customers = new List<Customer> {
        new Customer(1, "Moshe Levy", "Chatam Sofer 19","BB","0555",null, null, true),
        new Customer(2, "Moshe Cohen", "Chatam Sofer 19","BB","0111",null, null, true)
        };

        public List<Customer> GetCustomers()
        {
            return Customers;
        }

        public Customer? GetCustomerById(int id)
        {
            return Customers.Find(c => c.Id == id);
        }
        public void AddCustomer(Customer customer)
        {
            Customers.Add(customer);
        }
        public void RemoveCustomer(int id)
        {
            int index = Customers.FindIndex(c => c.Id == id);
            if (index != -1)
            {
                Customers.RemoveAt(index);
            }
        }
        public void UpdateCustomer(int id, Customer customer)
        {
            int index = Customers.FindIndex(c => c.Id == id);
            if (index != -1)
                Customers.Insert(index, customer);
        }
    }
}






