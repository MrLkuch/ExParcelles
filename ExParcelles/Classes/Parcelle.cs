using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExParcelles.Classes
{
    internal class Parcelle
    {
        private int _id_parcelle;
        private String _nom_parcelle;
        private String _coordonnees;
        private float _surface;

        static private int _id_count = 0;

        public int Id_parcelle { get => _id_count; }
        public String Nom_parcelle {  get => _nom_parcelle; set => _nom_parcelle = value;}
        public String Coordonnes {  get => _coordonnees; set => _coordonnees = value;}
        public float Surface { get => _surface; set => _surface = value;}

        public Parcelle (String nom_parcelle, String coordonnees, float surface)
        {
            _id_parcelle = _id_count++;
            Nom_parcelle = nom_parcelle;
            Surface = surface;
            Coordonnes = coordonnees;
        }
    }
}
