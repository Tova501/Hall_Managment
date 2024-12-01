using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hall.Core.Entities
{
    public enum Kashrut { HARAV_LANDO, SHEERIT_ISRAEL }//ADD MORE
    public class Catering
    {
        private static int nextId = 1;

        public int Id { get; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string? Email { get; set; }
        public Kashrut Kashrut { get; set; }
        public bool Waiters { get; set; }
        public string? LeadingPhone { get; set; }

        public Catering(string name, string phone, string? email, Kashrut kashrut, bool waiters, string? leadingPhone)
        {
            Id = nextId;
            nextId++;

            Name = name;
            Phone = phone;
            Email = email;
            Kashrut = kashrut;
            Waiters = waiters;
            LeadingPhone = leadingPhone;
        }

    }
}
