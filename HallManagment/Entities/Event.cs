namespace HallManagment.Entities
{
    public class Event
    {
        public int Id { get; set; }
        public DateOnly Date { get; set; }
        public string Description { get; set; }
        public int CustId { get; set; }
        public int CateringId { get; set; }

        public int PaymentId { get; set; }
        public int Price { get; set; }

        public TimeOnly StartHour { get; set; }
        public TimeOnly EndHour { get; set; }
        public DateOnly UpdateDate { get; set; }

        public int NumParticipants { get; set; }
        public bool Cleaning { get; set; }

        public bool Amplification { get; set; }
        public bool Closed { get; set; } = false;

        public Event()
        {

        }

        public Event(int id, DateOnly date, string description,int custId, int cateringId, int paymentId, int price, TimeOnly startHour, TimeOnly endHour, DateOnly updateDate, int numParticipants, bool cleaning, bool amplification)
        {
            Id = id;
            Date = date;
            Description = description;
            CustId = custId;
            CateringId = cateringId;
            PaymentId = paymentId;
            Price = price;
            StartHour = startHour;
            EndHour = endHour;
            UpdateDate = updateDate;
            NumParticipants = numParticipants;
            Cleaning = cleaning;
            Amplification = amplification;
        }
    }
}
