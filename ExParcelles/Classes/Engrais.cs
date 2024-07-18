using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExParcelles.Classes
{
    internal class Engrais
    {
        private int _id_engrais;
        private String _nom_engrais;

        private String _un;

        static private int _id_count = 0;

        public int Id_engrais { get => _id_engrais;}
        public String Nom_engrais { get => _nom_engrais; set => _nom_engrais = value; }

        public String Un { get => _un; }

        public Engrais (String nom_engrais, Unite unite)
        {
            _id_engrais = _id_count++;
            Nom_engrais = nom_engrais;

            _un = unite.Un;
            
        }
    }
}
