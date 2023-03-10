using EcoTravel_MB_COMMON.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoTravel_MB_COMMON.Repositories
{
    public interface IType_LogementRepository<TEntity, TId> : IGetRepository<TEntity, TId> where TEntity : IType_Logement
    {
    }
}
