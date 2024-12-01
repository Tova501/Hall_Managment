using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hall.Core.Entities
{
    public class Event
    {
        private static int nextId = 1;

        public int Id { get; }
        public DateOnly Date { get; set; }
        public string Description { get; set; }
        public int CustId { get; set; }
        public int CateringId { get; set; }
        public int AdvancePaymentId { get; set; }
        public int BalancePaymentId { get; set; }
        public int Price { get; set; }
        public TimeOnly StartHour { get; set; }
        public TimeOnly EndHour { get; set; }
        public DateOnly UpdateDate { get; set; }
        public int NumParticipants { get; set; }
        public bool Cleaning { get; set; }
        public bool Amplification { get; set; }
        public bool Closed { get; set; } = false;

        public Event(DateOnly date, string description, int custId, int cateringId, int advancePaymentId, int balancePaymentId, int price, TimeOnly startHour, TimeOnly endHour, DateOnly updateDate, int numParticipants, bool cleaning, bool amplification, bool closed)
        {
            Id = nextId;
            nextId++;

            Date = date;
            Description = description;
            CustId = custId;
            CateringId = cateringId;
            AdvancePaymentId = advancePaymentId;
            BalancePaymentId = balancePaymentId;
            Price = price;
            StartHour = startHour;
            EndHour = endHour;
            UpdateDate = updateDate;
            NumParticipants = numParticipants;
            Cleaning = cleaning;
            Amplification = amplification;
            Closed = closed;
        }
    }

}
