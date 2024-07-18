using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExParcelles.Classes
{
    internal class Epandre
    {
        private int _qte_epandue;

        private int _id_engrais;
        private int _id_parcelle;
        private DateTime _date;

        public int Qte_epandue { get => _qte_epandue; set => _qte_epandue = value; }
        
        public int Id_engrais { get => _id_engrais;}
        public int Id_parcelle { get => _id_parcelle;}
        public DateTime Date { get => _date; }

        public Epandre(int qte_epandue, Engrais engrais, Parcelle parcelle, Date date)
        {
            Qte_epandue = qte_epandue;

            _id_engrais = engrais.Id_engrais;
            _id_parcelle = parcelle.Id_parcelle;
            _date = date.Val_date;
            
        }
    }
}
