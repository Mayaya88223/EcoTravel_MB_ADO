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
    public class LogementService : BaseService, ILogementRepository<Logement, int>
    {
        public LogementService(IConfiguration config) : base(config, "EcoTravel-DB")
        {
        }
        public IEnumerable<Logement> Get()
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT [IdLogement], [Nom], [Prix], [Adresse_CP], [Adresse_Num], [Adresse_Rue], [Adresse_Pays], [Geo_Latitude], [Geo_Longitude], [Descriptionc_Courte], [Description_Longue], [Nombre_Chambres], [Nombre_Pieces], [Capacity_NbreMaxPersonnes], [Nbre_SDB], [Nbre_WC], [Balcon], [Air_Conditionning], [Wifi], [Mini_Bar], [Animaux_accepted], [Piscine], [Voiturier], [Room_Service], [Type], [IdClient], [IdPhoto], [Date_Creation] FROM [Logement]";
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            yield return reader.ToLogement();
                        }
                    }
                }
            }
        }

        public Logement Get(int id)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT [IdLogement], [Nom], [Prix], [Adresse_CP], [Adresse_Num], [Adresse_Rue], [Adresse_Pays], [Geo_Latitude], [Geo_Longitude], [Descriptionc_Courte], [Description_Longue], [Nombre_Chambres], [Nombre_Pieces], [Capacity_NbreMaxPersonnes], [Nbre_SDB], [Nbre_WC], [Balcon], [Air_Conditionning], [Wifi], [Mini_Bar], [Animaux_accepted], [Piscine], [Voiturier], [Room_Service], [Type], [IdClient], [IdPhoto], [Date_Creation] FROM [Logement] WHERE [IdLogement] = @Id";
                    command.Parameters.AddWithValue("Id", id);
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read()) return reader.ToLogement();
                        return null;

                    }
                }
            }
        }


        public int Insert(Logement entity)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = @"INSERT INTO [Logement] ([Nom], [Prix], [Adresse_CP], [Adresse_Num], [Adresse_Rue], [Adresse_Pays], [Geo_Latitude], [Geo_Longitude], [Descriptionc_Courte], [Description_Longue], [Nombre_Chambres], [Nombre_Pieces], [Capacity_NbreMaxPersonnes], [Nbre_SDB], [Nbre_WC], [Balcon], [Air_Conditionning], [Wifi], [Mini_Bar], [Animaux_accepted], [Piscine], [Voiturier], [Room_Service], [Type], [IdClient], [IdPhoto], [Date_Creation])
                                            OUTPUT [inserted].[IdLogement]
                                            VALUES (@Nom, @Prix, @Adresse_CP, @Adresse_Num, @Adresse_Rue, @Adresse_Pays, @Geo_Latitude, @Geo_Longitude, @Descriptionc_Courte, @Description_Longue, @Nombre_Chambres, @Nombre_Pieces, @Capacity_NbreMaxPersonnes, @Nbre_SDB, @Nbre_WC, @Balcon, @Air_Conditionning, @Wifi, @Mini_Bar, @Animaux_accepted, @Piscine, @Voiturier, @Room_Service, @Type, @IdClient, @IdPhoto, @Date_Creation)";

                    connection.Open();
                    return (int)command.ExecuteScalar();
                }
            }
        }

        public bool Update(int id, Logement entity)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = @"UPDATE [Client]
                                            SET [Nom] = @Nom ,
                                                [Prix] = @Prix,
                                                [Adresse_CP] = @Adresse_CP ,
                                                [Adresse_Num] = @Adresse_Num ,
                                                [Adresse_Rue] = @Adresse_Rue ,
                                                [Adresse_Pays] = @Adresse_Pays ,
                                                [Geo_Latitude] = @Geo_Latitude ,
                                                [Geo_Longitude] = @Geo_Longitude ,
                                                [Description_Courte] = @Description_Courte ,
                                                [Description_Longue] = @Description_Longue ,
                                                [Nombre_Chambres] = @Nombre_Chambres ,
                                                [Nombre_Pieces] = @Nombre_Pieces ,
                                                [Capacity_NbreMaxPersonnes] = @Capacity_NbreMaxPersonnes ,
                                                [Nbre_SDB] = @Nbre_SDB,
                                                [Nbre_WC] = @Nbre_WC,
                                                [Balcon] = @Balcon ,
                                                [Air_Conditionning] = @Air_Conditionning ,
                                                [Wifi] = @Wifi ,
                                                [Mini_Bar] = @Mini_Bar ,
                                                [Animaux_accepted] = @Animaux_accepted ,
                                                [Piscine] = @Piscine ,
                                                [Voiturier] = @Voiturier ,
                                                [Room_Service] = @Room_Service,
                                            WHERE [IdLogement] = @Id";
                    command.Parameters.AddWithValue("Nom", entity.Nom);
                    command.Parameters.AddWithValue("Prix", entity.Prix);
                    command.Parameters.AddWithValue("Adresse_CP", entity.Adresse_CP);
                    command.Parameters.AddWithValue("Adresse_Num", entity.Adresse_Num);
                    command.Parameters.AddWithValue("Adresse_Rue", entity.Adresse_Rue);
                    command.Parameters.AddWithValue("Adresse_Pays", entity.Adresse_Pays);
                    command.Parameters.AddWithValue("Geo_Latitude", entity.Geo_Latitude);
                    command.Parameters.AddWithValue("Geo_Longitude", entity.Geo_Longitude);
                    command.Parameters.AddWithValue("Description_Courte", entity.Description_Courte);
                    command.Parameters.AddWithValue("Description_Longue", entity.Description_Longue);
                    command.Parameters.AddWithValue("Nombre_Chambres", entity.Nombre_Chambres);
                    command.Parameters.AddWithValue("Nombre_Pieces", entity.Nombre_Pieces);
                    command.Parameters.AddWithValue("Capacity_NbreMaxPersonnes", entity.Capacity_NbreMaxPersonnes);
                    command.Parameters.AddWithValue("Nbre_SDB", entity.Nbre_SDB);
                    command.Parameters.AddWithValue("Nbre_WC", entity.Nbre_WC);
                    command.Parameters.AddWithValue("Balcon", entity.Balcon);
                    command.Parameters.AddWithValue("Air_Conditionning", entity.Air_Conditionning);
                    command.Parameters.AddWithValue("Wifi", entity.Wifi);
                    command.Parameters.AddWithValue("Mini_Bar", entity.Mini_Bar);
                    command.Parameters.AddWithValue("Animaux_accepted", entity.Animaux_accepted);
                    command.Parameters.AddWithValue("Piscine", entity.Piscine);
                    command.Parameters.AddWithValue("Voiturier", entity.Voiturier);
                    command.Parameters.AddWithValue("Room_Service", entity.Room_Service);
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
                    command.CommandText = "DELETE FROM [Logement] WHERE [IdLogement] = @Id";
                    command.Parameters.AddWithValue("Id", id);
                    connection.Open();
                    return command.ExecuteNonQuery() > 0;
                }
            }
        }
    }
}