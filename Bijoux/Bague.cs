using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel
{
    public class Bague : Bijoux
    {
        private bool _rhodiage;
        private decimal _diametre;

        public bool Rhodiage => _rhodiage;
        public decimal Diametre => _diametre;

        public Bague(string Name, string Material, string Poids, string Couleur, string Sexe,string Taille, string Fabricant, bool Rhodiage,decimal Diametre) : base(Name,Material,Poids,Couleur,Sexe,Taille,Fabricant)
        {
            _rhodiage = Rhodiage;
            _diametre = Diametre;
        }
    }
}
