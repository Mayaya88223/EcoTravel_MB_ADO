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
    public class IndisponibiliteService : BaseService, IIndisponibiliteRepository<Indisponibilite, int>
    {
        public IndisponibiliteService(IConfiguration config) : base(config, "EcoTravel-DB")
        {
        }


        public IEnumerable<Indisponibilite> Get()
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT [IdIndisponible], [Date_debut], [Date_fin], [IdLogement] FROM [Indisponibilite]";
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            yield return reader.ToIndisponibilite();
                        }
                    }
                }
            }
        }

        public Indisponibilite Get(int id)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT [IdIndisponible], [Date_debut], [Date_fin], [IdLogement] FROM [Indisponibilite] WHERE [IdIndisponible] = @Id";
                    command.Parameters.AddWithValue("Id", id);
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read()) return reader.ToIndisponibilite();
                        return null;

                    }
                }
            }
        }


        public int Insert(Indisponibilite entity)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = @"INSERT INTO [Indisponibilite] ([Date_debut], [Date_fin], [IdLogement])
                                            OUTPUT [inserted].[IdIndisponible]
                                            VALUES (@Date_debut, @Date_fin, @IdLogement)";
                    connection.Open();
                    return (int)command.ExecuteScalar();
                }
            }
        }

        public bool Update(int id, Indisponibilite entity)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = @"UPDATE [Indisponibilite]
                                            SET [Date_debut] = @Date_debut,
                                                [Date_fin] = @Date_fin,
                                                [IdLogement] = IdLogement,
                                            WHERE [IdAvis] = @Id";
                    command.Parameters.AddWithValue("Date_debut", entity.Date_debut);
                    command.Parameters.AddWithValue("Date_fin", entity.Date_fin);
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
                    command.CommandText = "DELETE FROM [Indisponibilite] WHERE [IdIndisponible] = @Id";
                    command.Parameters.AddWithValue("Id", id);
                    connection.Open();
                    return command.ExecuteNonQuery() > 0;
                }
            }
        }


    }
}
