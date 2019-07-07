using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DomainModel;
namespace UseCase
{
    public class GestionBijoux : IGestionBijoux<Bijoux, InfoCreationBijoux, BijouxFiltre>
    {
        public Bijoux CreateBijoux(InfoCreationBijoux createParam)
        {
            return new Bijoux(createParam.Name, createParam.Material, createParam.Poids, createParam.Couleur,createParam.Sexe,createParam.Taille, createParam.Fabriquant);
        }

        public Bijoux GetBijoux(BijouxFiltre entityFilter)
        {
            throw new NotImplementedException();
        }

        public void SupprimerBijoux(BijouxFiltre entityFilter)
        {
            throw new NotImplementedException();
        }
    }
}
