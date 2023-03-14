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
    public class ClientService : BaseService, IClientRepository<Client, int>
    {
        public ClientService(IConfiguration config) : base(config, "EcoTravel-DB")
        {
        }

        public IEnumerable<Client> Get()
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT [IdClient], [Nom], [Prénom], [Email], [Pays], [Telephone] FROM [Client]";
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            yield return reader.ToClient();
                        }
                    }
                }
            }
        }

        public Client Get(int id)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT [IdClient], [Nom], [Prénom], [Email], [Pays], [Telephone] FROM [Client] WHERE [IdClient] = @Id";
                    command.Parameters.AddWithValue("Id", id);
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read()) return reader.ToClient();
                        return null;

                    }
                }
            }
        }


        public int Insert(Client entity)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SP_Client_Add";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("Nom", entity.Nom);
                    command.Parameters.AddWithValue("Prénom", entity.Prénom);
                    command.Parameters.AddWithValue("Email", entity.Email);
                    command.Parameters.AddWithValue("Pays", entity.Pays);
                    command.Parameters.AddWithValue("Telephone", entity.Pays);
                    command.Parameters.AddWithValue("Password", entity.Password);

                    connection.Open();
                    return (int)command.ExecuteScalar();
                }
            }
        }

        public bool Update(int id, Client entity)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = @"UPDATE [Client]
                                            SET [Nom] = @Nom,
                                                [Prénom] = @Prénom,
                                                [Email] = @Email,
                                                [Pays] = @Pays,
                                                [Telephone] = @Telephone,
                                                [Password] = @Password,
                                            WHERE [IdClient] = @id";
                    command.Parameters.AddWithValue("Nom", entity.Nom);
                    command.Parameters.AddWithValue("Prénom", entity.Prénom);
                    command.Parameters.AddWithValue("Email", entity.Email);
                    command.Parameters.AddWithValue("Pays", entity.Pays);
                    command.Parameters.AddWithValue("Telephone", entity.Pays);
                    command.Parameters.AddWithValue("Password", entity.Password);
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
                    command.CommandText = "DELETE FROM [Client] WHERE [IdClient] = @Id";
                    command.Parameters.AddWithValue("Id", id);
                    connection.Open();
                    return command.ExecuteNonQuery() > 0;
                }
            }
        }


        public int? CheckPassword(string email, string password)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SP_ClientCheck";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("Email", email);
                    command.Parameters.AddWithValue("Password", password);
                    connection.Open();
                    object result = command.ExecuteScalar();
                    return (result is DBNull) ? null : (int?)result;
                }
            }
        }

        
    }
}

