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
    public class AvisService : BaseService, IAvisRepository<Avis, int>
    {
        public AvisService(IConfiguration config) : base(config, "EcoTravel-DB")
        {
        }

        
        public IEnumerable<Avis> Get()
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT [IdAvis], [Notes], [Commentaire], [Categorie_User] FROM [Avis]";
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            yield return reader.ToAvis();
                        }
                    }
                }
            }
        }

        public Avis Get(int id)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT [IdAvis], [Notes], [Commentaire], [Categorie_User] FROM [Avis] WHERE [IdAvis] = @Id";
                    command.Parameters.AddWithValue("Id", id);
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read()) return reader.ToAvis();
                        return null;

                    }
                }
            }
        }


        public int Insert(Avis entity)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = @"INSERT INTO [Avis] ([Notes], [Commentaire], [Categorie_User])
                                            OUTPUT [inserted].[IdAvis]
                                            VALUES (@Notes, @Commentaire, @Categorie_User)";
                    connection.Open();
                    return (int)command.ExecuteScalar();
                }
            }
        }

        public bool Update(int id, Avis entity)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = @"UPDATE [Avis]
                                            SET [Notes] = @Nom,
                                                [Commentaire] = @Prénom,
                                                [Categorie_User] = @Email,
                                            WHERE [IdAvis] = @Id";
                    command.Parameters.AddWithValue("Notes", entity.Notes);
                    command.Parameters.AddWithValue("Commentaire", entity.Commentaire);
                    command.Parameters.AddWithValue("Categorie_User", entity.Categorie_User);
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
                    command.CommandText = "DELETE FROM [Avis] WHERE [IdAvis] = @Id";
                    command.Parameters.AddWithValue("Id", id);
                    connection.Open();
                    return command.ExecuteNonQuery() > 0;
                }
            }
        }

        
    }
}
