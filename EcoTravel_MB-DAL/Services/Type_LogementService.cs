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
    public class Type_LogementService : BaseService, IType_LogementRepository<Type_Logement, int>
    {
        public Type_LogementService(IConfiguration config) : base(config, "EcoTravel-DB")
        {
        }

        public IEnumerable<Type_Logement> Get()
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT [IdType], [Description], [Type] FROM [Type_Logement]";
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            yield return reader.ToType_Logement();
                        }
                    }
                }
            }
        }

        public Type_Logement Get(int id)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT [IdType], [Description], [Type] FROM [Type_Logement] WHERE [IdType] = @Id";
                    command.Parameters.AddWithValue("Id", id);
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read()) return reader.ToType_Logement();
                        return null;

                    }
                }
            }
        }
    }
}

