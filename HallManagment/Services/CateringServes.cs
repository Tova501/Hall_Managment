using HallManagment.Entities;
using Microsoft.Extensions.Logging;

namespace HallManagment.Services
{

    public class CateringServes
    {


        private List<Catering> Caterings = new List<Catering>() {
            new Catering(1, "Kaplan", "777",null,Kashrut.HARAV_LANDO, false, "111"),
            new Catering(2, "Kantor", "555","f@jkl", Kashrut.SHEERIT_ISRAEL, true, "888")
        };

        public void AddCatering(Catering catering)
        {
            Caterings.Add(catering);
        }
        public void DeleteCatering(int cateringId)
        {
            int index = Caterings.FindIndex(c => c.Id == cateringId);
            if (index != -1)
            {
                Caterings.RemoveAt(index);
            }
        }
        public List<Catering> GetCaterings()
        {
            return Caterings;
        }
        public Catering? GetCateringById(int id)
        {
            return Caterings.Find(c => c.Id == id);
        }
        public void UpdateCatering(int id, Catering catering)
        {
            int index = Caterings.FindIndex(c => c.Id == id);
            if (index != -1)
                Caterings[index] = catering;
        }
    }
}
