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
    public class ReservationService : IReservationRepository<Reservation, int>
    {
        public readonly IReservationRepository<EcoTravel_MB_DAL.Entities.Reservation, int> _repository;

        public ReservationService(IReservationRepository<EcoTravel_MB_DAL.Entities.Reservation, int> repository)
        {
            _repository = repository;
        }

       

       public IEnumerable<Reservation> Get()
        {
            return _repository.Get().Select(e => e.ToBLL());
        }

        public Reservation Get(int id)
        {
            return _repository.Get(id).ToBLL();
        }



        public int Insert(Reservation entity)
        {
            return _repository.Insert(entity.ToDAL());
        }

        public bool Update(int id, Reservation entity)
        {
            return _repository.Update(id, entity.ToDAL());
        }




        public bool Delete(int id)
        {
            return _repository.Delete(id);
        }

        public IEnumerable<Reservation> GetByReservation(int id)
        {
            throw new NotImplementedException();
        }
    }


}