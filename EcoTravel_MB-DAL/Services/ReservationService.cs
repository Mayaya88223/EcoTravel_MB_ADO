using EcoTravel_MB_COMMON.Repositories;
using EcoTravel_MB_DAL.Entities;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoTravel_MB_DAL.Services
{
    public class ReservationService : BaseService, IReservationRepository<Reservation, int>
    {
        public ReservationService(IConfiguration config) : base(config, "EcoTravel-DB")
        {
        }

        public IEnumerable<Reservation> Get()
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT [IdReservation], [Frais_Sejour], [Taxe_Sejour], [Assurance_annulation], [IdAvis], [IdIndisponibilite], [IdLogement], [IdClient], [Date_debut], [Date_fin] FROM [Reservation]";
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            yield return reader.ToReservation();
                        }
                    }
                }
            }
        }

        public Reservation Get(int id)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT [IdReservation], [Frais_Sejour], [Taxe_Sejour], [Assurance_annulation], [IdAvis], [IdIndisponibilite], [IdLogement], [IdClient], [Date_debut], [Date_fin] FROM [Reservation] WHERE [IdReservation] = @Id";
                    command.Parameters.AddWithValue("Id", id);
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read()) return reader.ToReservation();
                        return null;

                    }
                }
            }
        }


        public int Insert(Reservation entity)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = @"INSERT INTO [Reservation] ([Frais_Sejour], [Taxe_Sejour], [Assurance_annulation], [IdAvis], [IdIndisponibilite], [IdLogement], [IdClient], [Date_debut], [Date_fin])
                                            OUTPUT [inserted].[IdLogement]
                                            VALUES (@Frais_Sejour, @Taxe_Sejour, @Assurance_annulation, @IdAvis, @IdIndisponibilite, @IdLogement, @IdClient, @Date_debut, @Date_fin)";

                    connection.Open();
                    return (int)command.ExecuteScalar();
                }
            }
        }

        public bool Update(int id, Reservation entity)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = @"UPDATE [Reservation]
                                            SET [Frais_Sejour] = @Frais_Sejour ,
                                                [Taxe_Sejour] = @Taxe_Sejour,
                                                [Assurance_annulation] = @Assurance_annulation ,
                                                [IdAvis] = @IdAvis ,
                                                [IdIndisponibilite] = @IdIndisponibilite ,
                                                [IdLogement] = @IdLogement ,
                                                [IdClient] = @IdClient ,
                                                [Date_debut] = @Date_debut ,
                                                [Date_fin] = @Date_fin                                                
                                            WHERE [IdReservation] = @Id";
                    command.Parameters.AddWithValue("Frais_Sejour", entity.Frais_Sejour);
                    command.Parameters.AddWithValue("Taxe_Sejour", entity.Taxe_Sejour);
                    command.Parameters.AddWithValue("Assurance_annulation ", entity.Assurance_annulation);
                    command.Parameters.AddWithValue("IdAvis", entity.IdAvis);
                    command.Parameters.AddWithValue("IdIndisponibilite", entity.IdIndisponibilite);
                    command.Parameters.AddWithValue("IdLogement", entity.IdLogement);
                    command.Parameters.AddWithValue("IdClient", entity.IdClient);
                    command.Parameters.AddWithValue("Date_debut", entity.Date_debut);
                    command.Parameters.AddWithValue("Date_fin", entity.Date_fin);
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
                    command.CommandText = "DELETE FROM [Reservation] WHERE [IdReservation] = @Id";
                    command.Parameters.AddWithValue("Id", id);
                    connection.Open();
                    return command.ExecuteNonQuery() > 0;
                }
            }
        }
    }
}

