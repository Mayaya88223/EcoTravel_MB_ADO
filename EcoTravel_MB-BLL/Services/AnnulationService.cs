using DAL = EcoTravel_MB_DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EcoTravel_MB_COMMON.Repositories;
using EcoTravel_MB_BLL.Entities;
using EcoTravel_MB_BLL.Mapper;

namespace EcoTravel_MB_BLL.Services
{
    public class AnnulationService : IAnnulationRepository<Annulation, int>
    {
        public readonly IAnnulationRepository <DAL.Entities.Annulation, int> _repository;

        public AnnulationService(IAnnulationRepository<DAL.Entities.Annulation, int> repository)
        {
            _repository = repository;
        }
      


        public IEnumerable<Annulation> Get()
        {
            return _repository.Get().Select(e => e.ToBLL());
        }

        public Annulation Get(int id)
        {
            return _repository.Get(id).ToBLL();
        }

        public int Insert(Annulation entity)
        {
            return _repository.Insert(entity.ToDAL());
        }

    }
}
