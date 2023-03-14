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
    public class IndisponibiliteService : IIndisponibiliteRepository <Indisponibilite, int>
    {
        public readonly IIndisponibiliteRepository<EcoTravel_MB_DAL.Entities.Indisponibilite, int> _repository;

        public IndisponibiliteService(IIndisponibiliteRepository<EcoTravel_MB_DAL.Entities.Indisponibilite, int> repository)
        {
            _repository = repository;
        }

        public IEnumerable<Indisponibilite> Get()
        {
            return _repository.Get().Select(e => e.ToBLL());
        }

        public Indisponibilite Get(int id)
        {
            return _repository.Get(id).ToBLL();
        }

        public int Insert(Indisponibilite entity)
        {
            return _repository.Insert(entity.ToDAL());
        }

        public bool Update(int id, Indisponibilite entity)
        {
            return _repository.Update(id, entity.ToDAL());
        }

        public bool Delete(int id)
        {
            return _repository.Delete(id);
        }
    }


}
