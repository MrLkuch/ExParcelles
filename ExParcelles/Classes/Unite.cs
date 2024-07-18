using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExParcelles.Classes
{
    internal class Unite
    {
        private int _val_unite;

        public int Val_unite { get => _val_unite; set => _val_unite = value; }

        public Unite(int val_unite)
        {
            Val_unite = val_unite;
        }
    }
}
