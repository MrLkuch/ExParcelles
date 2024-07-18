using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExParcelles.Classes
{
    internal class Unite
    {
        private String _un;

        public String Un { get => _un; set => _un = value; }

        public Unite(String val_unite)
        {
            Un = val_unite;
        }
    }
}
