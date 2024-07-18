using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExParcelles.Classes
{
    internal class Posseder
    {
        private int _valeur;

        private int _id_engrais;
        private String _id_element;

        public int Valeur { get => _valeur}
        public int Id_engrais { get => _id_engrais; }
        public String Id_element { get => _id_element; }

        public Posseder (int valeur, Engrais engrais, Elem_chimique elem_chimique)
        {
            _valeur = valeur;
            _id_engrais = engrais.Id_engrais;
            _id_element = elem_chimique.Id_element;
        }
    }
}
