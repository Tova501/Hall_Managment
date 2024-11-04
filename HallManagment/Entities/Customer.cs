
using System.Runtime.CompilerServices;

namespace HallManagment.Entities
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Phone { get; set; }
        public string? AnotherPhone { get; set; }
        public string? Email { get; set; }
        public bool CommunityMember { get; set; }

        public Customer()
        {

        }
        public Customer(int id, string name, string address, string city, string phone, string? anotherPhone, string? email, bool communityMember)
        {
            Id = id;
            Name = name;
            Address = address;
            City = city;
            Phone = phone;
            AnotherPhone = anotherPhone;
            Email = email;
            CommunityMember = communityMember;
        }

    }
}
