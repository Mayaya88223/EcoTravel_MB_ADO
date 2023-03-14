using EcoTravel_MB_COMMON.Repositories;
using EcoTravel_MB_DAL.Entities;
using EcoTravel_MB_DAL.Mapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoTravel_MB_DAL.Services
{
    public class PhotoService : BaseService, IPhotoRepository<Photo, int>
    {
        public PhotoService(IConfiguration config) : base(config, "EcoTravel-DB")
        {
        }


        public IEnumerable<Photo> Get()
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT [IdPhoto], [Description], [Image], [IdLogement] FROM [Photo]";
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            yield return reader.ToPhoto();
                        }
                    }
                }
            }
        }

        public Photo Get(int id)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT [IdPhoto], [Description], [Image], [IdLogement] FROM [Photo] WHERE [IdPhoto] = @Id";
                    command.Parameters.AddWithValue("Id", id);
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read()) return reader.ToPhoto();
                        return null;

                    }
                }
            }
        }


        public int Insert(Photo entity)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = @"INSERT INTO [Description], [Image], [IdLogement])
                                            OUTPUT [inserted].[IdPhoto]
                                            VALUES (@Description, @Image, @IdLogement)";
                    connection.Open();
                    return (int)command.ExecuteScalar();
                }
            }
        }

        public bool Update(int id, Photo entity)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = @"UPDATE [Photo]
                                            SET [Description] = @Description,
                                                [Image] = @Image,
                                                [IdLogement] = IdLogement,
                                            WHERE [IdAvis] = @Id";
                    command.Parameters.AddWithValue("Description", entity.Description);
                    command.Parameters.AddWithValue("Image", entity.Image);
                    command.Parameters.AddWithValue("IdLogement", entity.IdLogement);
                    command.Parameters.AddWithValue("Id", id);
                    connection.Open();
                    return command.ExecuteNonQuery() > 0;
                }
            }
        }




        public bool Delete(int id)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "DELETE FROM [Photo] WHERE [IdPhoto] = @Id";
                    command.Parameters.AddWithValue("Id", id);
                    connection.Open();
                    return command.ExecuteNonQuery() > 0;
                }
            }
        }


    }
}
