using EcoTravel_MB_COMMON.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoTravel_MB_COMMON.Repositories
{
    public interface IAnnulationRepository <TEntity, TId> where TEntity : IAnnulation
    {
        IEnumerable<TEntity> Get();
        TEntity Get(TId id);

        TId Insert(TEntity entity);
        
    }
}
