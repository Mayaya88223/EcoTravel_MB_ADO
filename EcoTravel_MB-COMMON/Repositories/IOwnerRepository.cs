using EcoTravel_MB_COMMON.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoTravel_MB_COMMON.Repositories
{
    public interface IOwnerRepository<TEntity, TId> : IRepository<TEntity, TId> where TEntity : IOwner
    {
        int? CheckPassword(string email, string password);

        IEnumerable<TEntity> GetByLogement(int IdLogement);
    }
}
