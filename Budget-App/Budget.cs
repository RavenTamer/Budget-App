using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Budget_App
{
    public class Budget
    {
        Category category;
        string currency;
        string note;
        string time;
        decimal moneyamount;

        public Category Category { get { return category; } set { category = value; } }

        public string Currency { get { return currency; } set { currency = value; } }

        public string Time { get { return time; } set { time = value; } }

        public string Note { get { return note; } set { note = value; } }

        public decimal MoneyAmount { get { return moneyamount; } set { moneyamount = value; } }
        public override string ToString()
        {
            return this.note;
        }
    }
}
