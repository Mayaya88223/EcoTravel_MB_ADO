using EcoTravel_MB_DAL;
using EcoTravel_MB_COMMON.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EcoTravel_MB_BLL.Entities;
using EcoTravel_MB_BLL.Mapper;

namespace EcoTravel_MB_BLL.Services
{
    public class LogementService : ILogementRepository<Logement, int>
    {
        private readonly ILogementRepository<EcoTravel_MB_DAL.Entities.Logement, int> _repository;
        private readonly IReservationRepository<EcoTravel_MB_DAL.Entities.Reservation, int> _repository_logement;


        public LogementService(ILogementRepository<EcoTravel_MB_DAL.Entities.Logement, int> repository, IReservationRepository<EcoTravel_MB_DAL.Entities.Reservation, int> repository_logement)
        {
            _repository = repository;
            _repository_logement = repository_logement;

        }
        public IEnumerable<Logement> Get()
        {
            return _repository.Get().Select(e => e.ToBLL());
        }

        

        public Logement Get(int id)
        {
            return _repository.Get(id).ToBLL();
        }

        public int Insert(Logement entity)
        {
            return _repository.Insert(entity.ToDAL());
        }

        public bool Update(int id, Logement entity)
        {
            return _repository.Update(id, entity.ToDAL());
        }




        public bool Delete(int id)
        {
            return _repository.Delete(id);
        }

        IEnumerable<Logement> ILogementRepository<Logement, int>.GetByReservation(int IdReservation)
        {
            return (IEnumerable<Logement>)_repository_logement.Get().Select(e => e.ToBLL());
        }
    }
}