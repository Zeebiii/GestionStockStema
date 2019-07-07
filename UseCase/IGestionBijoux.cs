using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseCase
{
    interface IGestionBijoux<TEntity,TCreateParam,TEntityFilter>
    {
        TEntity CreateBijoux(TCreateParam createParam);
        TEntity GetBijoux(TEntityFilter entityFilter);
        void SupprimerBijoux(TEntityFilter entityFilter);
    }
}
