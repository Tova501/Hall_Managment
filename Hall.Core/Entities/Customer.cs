using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hall.Core.Entities
{
    public class Customer
    {
        private static int nextId = 1;

        public int Id { get; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Phone { get; set; }
        public string? AnotherPhone { get; set; }
        public string? Email { get; set; }
        public bool CommunityMember { get; set; }

        public Customer(string name, string address, string city, string phone, string? anotherPhone, string? email, bool communityMember)
        {
            Id = nextId;
            nextId++;

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
