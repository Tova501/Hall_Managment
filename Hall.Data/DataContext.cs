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
        readonly string _path = "../Data";

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

        public bool SaveData()
        {
            return SaveEvents() &&
                    SaveCustomers() &&
                    SaveCaterings() &&
                    SavePayments();
        }

        public List<Event> LoadEvents()
        {
            string path = Path.Combine(_path, "Events.csv");
            using var reader = new StreamReader(path);
            using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);
            return csv.GetRecords<Event>().ToList();
        }
        public List<Catering> LoadCaterings()
        {
            string path = Path.Combine(_path, "Caterings.csv");
            using var reader = new StreamReader(path);
            using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);
            return csv.GetRecords<Catering>().ToList();
        }
        public List<Customer> LoadCustomers()
        {
            string path = Path.Combine(_path, "Customers.csv");
            using var reader = new StreamReader(path);
            using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);
            return csv.GetRecords<Customer>().ToList();
        }
        public List<Payment> LoadPayments()
        {
            string path = Path.Combine(_path, "Payments.csv");
            using var reader = new StreamReader(path);
            using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);
            return csv.GetRecords<Payment>().ToList();
        }

        public bool SaveEvents()
        {
            try
            {
                string path = Path.Combine(_path, "Events.csv");
                using var writer = new StreamWriter(path);
                using var csv = new CsvWriter(writer, CultureInfo.InvariantCulture);
                csv.WriteRecords(this.events);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool SaveCustomers()
        {
            try
            {
                string path = Path.Combine(_path, "Customers.csv");
                using var writer = new StreamWriter(path);
                using var csv = new CsvWriter(writer, CultureInfo.InvariantCulture);
                csv.WriteRecords(this.customers);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool SaveCaterings()
        {
            try
            {
                string path = Path.Combine(_path, "Caterings.csv");
                using var writer = new StreamWriter(path);
                using var csv = new CsvWriter(writer, CultureInfo.InvariantCulture);
                csv.WriteRecords(this.caterings);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool SavePayments()
        {
            try
            {
                string path = Path.Combine(_path, "Payments.csv");
                using var writer = new StreamWriter(path);
                using var csv = new CsvWriter(writer, CultureInfo.InvariantCulture);
                csv.WriteRecords(this.payments);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
