using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ExParcelles.Classes
{
    internal class Production
    {
        private int _id_production;
        private String _nom_production;

        private String _un;

        static private int _id_count = 0;

        public int Id_production { get => _id_production; }
        public String Nom_production { get => _nom_production; set => _nom_production = value; }
        public String Un { get => _un;}
        
    

    public Production(string nom_production, Unite unite)
        {
            _id_production = _id_count++;
            Nom_production = nom_production;     
            _un = unite.Un;

            
              
        }
    }
}
