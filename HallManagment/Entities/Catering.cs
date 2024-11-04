namespace HallManagment.Entities
{
    public enum Kashrut { HARAV_LANDO, SHEERIT_ISRAEL }//ADD MORE
    public class Catering
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Phone { get; set; }

        public string? Email { get; set; }

        public Kashrut Kashrut { get; set; }

        public bool Waiters { get; set; }

        public string? LeadingPhone { get; set; }

        public Catering()
        {

        }
        public Catering(int id, string name, string phone,string? email, Kashrut kashrut, bool waiters, string leadingphone)
        {
            Id = id;
            Name = name;
            Phone = phone;
            Email = email;
            Kashrut = kashrut;
            Waiters = waiters;
            LeadingPhone = leadingphone;
        }
    }
}
