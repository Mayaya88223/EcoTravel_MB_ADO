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
    public class AvisService : IAvisRepository<Avis, int>
    {
        private readonly IAvisRepository<DAL.Entities.Avis, int> _repository;


    

        public IEnumerable<Avis> Get()
        {
            return _repository.Get().Select(e => e.ToBLL());
        }

        public Avis Get(int id)
        {
            return _repository.Get(id).ToBLL();
        }

        public int Insert(Avis entity)
        {
            return _repository.Insert(entity.ToDAL());
        }

        public bool Update(int id, Avis entity)
        {
            return _repository.Update(id, entity.ToDAL());
        }

        public bool Delete(int id)
        {
            return _repository.Delete(id);
        }


    }

    


}