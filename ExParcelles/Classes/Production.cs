using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExParcelles.Classes
{
    internal class Production
    {
        private int _id_production;
        private String _nom;

        private Unite _unite;
        private String _val_unite;

        static private int _id_count = 1;

        public int Id_production { get => _id_production; }
        public String Name { get => _nom; set => _nom = value; }
        public Unite Unite { get => _unite; set => _unite = value; }
        public String Val_unite { get => _val_unite;}
        
    

    public Production(string nom, Unite unite)
        {
            _id_production = _id_count++; 
            _nom = nom;
            Unite = _unite;
            _val_unite = unite.Val_unite;
              
        }
    }
}
