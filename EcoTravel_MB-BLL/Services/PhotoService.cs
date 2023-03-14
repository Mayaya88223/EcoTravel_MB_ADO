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

    public class PhotoService : IPhotoRepository<Photo, int>
    {
        public readonly IPhotoRepository<EcoTravel_MB_DAL.Entities.Photo, int> _repository;

        public PhotoService(IPhotoRepository<EcoTravel_MB_DAL.Entities.Photo, int> repository)
        {
            _repository = repository;
        }
        public IEnumerable<Photo> Get()
        {
            return _repository.Get().Select(e => e.ToBLL());
        }

        public Photo Get(int id)
        {
            return _repository.Get(id).ToBLL();
        }

        public int Insert(Photo entity)
        {
            return _repository.Insert(entity.ToDAL());
        }

        public bool Update(int id, Photo entity)
        {
            return _repository.Update(id, entity.ToDAL());
        }

        public bool Delete(int id)
        {
            return _repository.Delete(id);
        }
    }


}
