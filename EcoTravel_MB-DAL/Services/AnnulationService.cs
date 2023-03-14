using EcoTravel_MB_COMMON.Repositories;
using EcoTravel_MB_DAL.Entities;
using EcoTravel_MB_DAL.Mapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoTravel_MB_DAL.Services
{
    public class AnnulationService : BaseService, IAnnulationRepository<Annulation, int>
    {
        public AnnulationService(IConfiguration config) : base(config, "EcoTravel-DB")
        {
        }

        public IEnumerable<Annulation> Get()
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT [IdReservation], [Date_annulation], [Proprio_annul], [IdClient] FROM [Annulation]";
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            yield return reader.ToAnnulation();
                        }
                    }
                }
            }
        }

        public Annulation Get(int id)
        { 
             using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    using (SqlCommand command = connection.CreateCommand())
                    {
                        command.CommandText = "SELECT [IdReservation], [Date_annulation], [Proprio_annul], [IdClient] FROM [Annulation] WHERE [IdClient] = @Id";
                        command.Parameters.AddWithValue("Id", id);
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read()) return reader.ToAnnulation();
                            return null;

                        }
                    }
                }
        }

        public int Insert(Annulation entity)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SP_Annulation_Add";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("IdReservation", entity.IdReservation);
                    command.Parameters.AddWithValue("Date_annulation", entity.Date_annulation);
                    command.Parameters.AddWithValue("Proprio_annul", entity.Proprio_annul);
                    command.Parameters.AddWithValue("IdClient", entity.IdClient);


                    connection.Open();
                    return (int)command.ExecuteScalar();
                }
            }
        }

    }
}
