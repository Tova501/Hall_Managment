using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hall.Core.Entities
{
    public class BankAccountDetails
    {
        public string AccountNum { get; set; }
        public DateOnly Validity {  get; set; }
        public string Cvv {  get; set; }
        public string IdCardHolder { get; set; }

        public BankAccountDetails(string accountNum, DateOnly validity, string cvv, string idCardHolder)
        {
            AccountNum = accountNum;
            Validity = validity;
            Cvv = cvv;
            IdCardHolder = idCardHolder;
        }
    }
}
