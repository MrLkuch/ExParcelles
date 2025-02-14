﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExParcelles.Classes
{
    internal class Elem_chimique
    {
        private String _id_element;
        private String _libelle_element;

        private String _un;

        static private int _id_count = 0;

        public String Id_element { get => _id_element; }
        public String Libelle_element { get => _libelle_element;set => _libelle_element = value;}
        public String Un { get => _un; }

        public Elem_chimique(String id_element, String libelle_element, Unite unite)
        {
            _id_element = id_element;
            Libelle_element = libelle_element;
            _un = unite.Un;
        }
    }
}
