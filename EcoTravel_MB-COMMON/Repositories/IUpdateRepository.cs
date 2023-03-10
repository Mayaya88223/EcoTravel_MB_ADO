using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoTravel_MB_COMMON.Repositories
{
    public interface IUpdateRepository<TEntity, TId>
    {
        bool Update(TId id, TEntity entity);
    }
}
