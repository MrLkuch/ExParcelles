using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExParcelles.Classes
{
    internal class Unite
    {
        private String _val_unite;

        public String Val_unite { get => _val_unite; set => _val_unite = value; }

        public Unite(String val_unite)
        {
            Val_unite = val_unite;
        }
    }
}
