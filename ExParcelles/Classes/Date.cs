using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExParcelles.Classes
{
    internal class Date
    {
        private DateTime _val_date;

        public DateTime Val_date { get => _val_date; set => _val_date = value; }

        public Date(DateTime val_date)
        {
            Val_date = val_date;
        }
    }
}
