using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper;
using Hall.Core.Entities;


namespace Hall.Data
{
    public class DataContext
    {
        readonly string _path = "";

        public List<Catering> caterings {  get; set; }

        public List<Event> events { get; set; }

        public List<Payment> payments { get; set; }

        public List<Customer> customers { get; set; }

        public DataContext()
        {
            caterings = LoadCaterings();
            events = LoadEvents();
            payments = LoadPayments();
            customers = LoadCustomers();
        }

        public List<Catering> LoadCatering()
        {
            string path = Path.Combine(_path, "Caterings.csv");
            using var reader = new StreamReader(path);
            using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);
            return csv.GetRecords<Catering>().ToList();
        }
    }
}
