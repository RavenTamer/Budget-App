using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budget_App
{
    internal class Budget
    {
        Category category;
        string currency;
        string note;
        string time;
        int moneyamount;

        public Category Category { get { return category; } set { category = value; } }
        public string Currency { get { return currency; } set { currency = value; } }
        public string Time { get { return time; } set { time = value; } }
        public string Note { get { return note; } set { note = value; } }
        public int MoneyAmount { get { return moneyamount; } set { moneyamount = value; } }
    }
}
