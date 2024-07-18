using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExParcelles.Classes
{
    internal class Culture
    {
        private int _id_culture;
        private DateTime _date_debut;
        private DateTime _date_fin;
        private float _qte_recoltee;

        private int _id_parcelle;

        private int _id_production;

        static private int _id_count = 0;

        public int Id_culture { get => _id_culture; }
        public DateTime Date_debut { get => _date_debut; set => _date_debut = value;}
        public DateTime Date_fin { get => _date_fin; set => _date_fin = value;}
        public float Qte_recoltee {  get => _qte_recoltee; set => _qte_recoltee = value;}

        public int Id_parcelle { get => _id_parcelle;}
        public int Id_production { get => _id_production;}

        public Culture (DateTime date_debut, DateTime date_fin, float qte_recoltee, Parcelle parcelle, Production production)
        {
            _id_culture = _id_count++;
            Date_debut = date_debut;
            Date_fin = date_fin;
            Qte_recoltee = qte_recoltee;

            _id_parcelle = parcelle.Id_parcelle;
            _id_production = production.Id_production;
        }
    }
}
