using DAL = EcoTravel_MB_DAL;
using EcoTravel_MB_BLL.Entities;
using EcoTravel_MB_COMMON.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EcoTravel_MB_BLL.Mapper;

namespace EcoTravel_MB_BLL.Services
{

    public class OwnerService : IOwnerRepository<Owner, int>
    {


        private readonly IOwnerRepository<EcoTravel_MB_DAL.Entities.Owner, int> _repository;
        private readonly ILogementRepository<EcoTravel_MB_DAL.Entities.Logement, int> _repository_logement;


        public OwnerService(IOwnerRepository<DAL.Entities.Owner, int> repository, ILogementRepository<DAL.Entities.Logement, int> repository_logement)
        {
            _repository = repository;
            _repository_logement = repository_logement;
        }



       

        public IEnumerable<Owner> Get()
        {
            return _repository.Get().Select(e => e.ToBLL());
        }

        public Owner Get(int id)
        {
            return _repository.Get(id).ToBLL();
        }

        public int Insert(Owner entity)
        {
            return _repository.Insert(entity.ToDAL());
        }

        public bool Update(int id, Owner entity)
        {
            return _repository.Update(id, entity.ToDAL());
        }


       

        public bool Delete(int id)
        {
            return _repository.Delete(id);
        }


        public int? CheckPassword(string email, string password)
        {
            return _repository.CheckPassword(email, password);
        }

        public IEnumerable<Owner> GetByLogement(int IdLogement)
        {
            throw new NotImplementedException();
        }
    }



}
