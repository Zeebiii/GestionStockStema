using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel
{
   public class Bijoux
   {
        protected string _name;
        protected string _material;
        protected string _poids;
        protected string _couleur;
        protected string _sexe;
        protected string _taille;
        protected string _fabriquant;

        public string Name => _name;
        public string Material => _material;
        public string Poids => _poids;
        public string Couleur => _couleur;
        public string Sexe => _sexe;
        public string Taille => _taille;
        public string Fabriquant => _fabriquant;

        public Bijoux(string Name,string Material, string Poids, string Couleur, string Sexe, string Taille, string Fabricant)
        {
            _name = Name;
            _material = Material;
            _poids = Poids;
            _couleur = Couleur;
            _sexe = Sexe;
            _taille = Taille;
            _fabriquant = Fabricant;
        }
        
   }
}
