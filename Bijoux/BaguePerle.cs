using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel
{
    public class BaguePerle : Bague
    {
        private string _typePerle;

        public string TypePerle => _typePerle;
        public BaguePerle(string Name, string Material, string Poids, string Couleur, string Sexe, string Taille, string Fabricant, bool Rhodiage, decimal Diametre, string TypePerle) : base(Name, Material, Poids, Couleur, Sexe, Taille, Fabricant, Rhodiage, Diametre)
        {
            _typePerle = TypePerle;
        }
    }
}
