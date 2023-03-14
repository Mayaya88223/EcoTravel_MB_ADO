using EcoTravel_MB_BLL.Entities;
using DAL = EcoTravel_MB_DAL;
using EcoTravel_MB_COMMON.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EcoTravel_MB_BLL.Mapper;

namespace EcoTravel_MB_BLL.Services
{
    public class ClientService : IClientRepository<Client, int>
    {
        private readonly IClientRepository<DAL.Entities.Client, int> _repository;

        public ClientService(IClientRepository<DAL.Entities.Client, int> repository)
        {
            _repository = repository;
        }
        public IEnumerable<Client> Get()
        {
            return _repository.Get().Select(e => e.ToBLL());
        }

        public Client Get(int id)
        {
            return _repository.Get(id).ToBLL();
        }

        public int Insert(Client entity)
        {
            return _repository.Insert(entity.ToDAL());
        }

        public bool Update(int id, Client entity)
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
    }
}