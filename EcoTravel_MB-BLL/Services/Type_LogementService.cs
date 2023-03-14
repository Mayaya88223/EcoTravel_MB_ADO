using EcoTravel_MB_BLL.Entities;
using EcoTravel_MB_BLL.Mapper;
using EcoTravel_MB_COMMON.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoTravel_MB_BLL.Services
{


    public class Type_LogementService : IType_LogementRepository<Type_Logement, int>
    {
        private readonly IType_LogementRepository<EcoTravel_MB_DAL.Entities.Type_Logement, int> _repository;

        public IEnumerable<Type_Logement> Get()
        {
            return _repository.Get().Select(e => e.ToBLL());
        }

        public Type_Logement Get(int id)
        {
            return _repository.Get(id).ToBLL();
        }


      



    }
}