using EcoTravel_MB_DAL.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoTravel_MB_DAL.Mapper
{
    static class Mapper
    {

        public static Annulation ToAnnulation(this IDataRecord record)
        {
            if (record is null) return null;
            return new Annulation()
            {
                IdReservation = (int)record[nameof(Annulation.IdReservation)],
                Date_annulation = (DateTime)record[nameof(Annulation.Date_annulation)],
                Proprio_annul = (bool)record[nameof(Annulation.Proprio_annul)],
                IdClient = (int)record[nameof(Annulation.IdClient)]

            };
        }

        public static Avis ToAvis(this IDataRecord record)
        {
            if (record is null) return null;
            return new Avis()
            {
                IdAvis = (int)record[nameof(Avis.IdAvis)],
                Notes = (int)record[nameof(Avis.Notes)],
                Commentaire = (string)record[nameof(Avis.Commentaire)],
                Categorie_User = (string)record[nameof(Avis.Categorie_User)]

            };
        }

        public static Client ToClient(this IDataRecord record)
        {
            if (record is null) return null;
            return new Client()
            {
                IdClient = (int)record[nameof(Client.IdClient)],
                Nom = (string)record[nameof(Client.Nom)],
                Prénom = (string)record[nameof(Client.Prénom)],
                Email = (string)record[nameof(Client.Email)],
                Pays = (string)record[nameof(Client.Pays)],
                Telephone = (string)record[nameof(Client.Telephone)],
                Password = "********"
            };
        }

        public static Indisponibilite ToIndisponibilite(this IDataRecord record)
        {
            if (record is null) return null;
            return new Indisponibilite()
            {
                IdIndisponible = (int)record[nameof(Indisponibilite.IdIndisponible)],
                Date_debut = (DateTime)record[nameof(Indisponibilite.Date_debut)],
                Date_fin = (DateTime)record[nameof(Indisponibilite.Date_fin)],
                IdLogement = (int)record[nameof(Indisponibilite.IdLogement)]

            };

        }


        public static Logement ToLogement(this IDataRecord record)
        {
            if (record is null) return null;
            return new Logement()
            {
                IdLogement= (int)record[nameof(Logement.IdLogement)],
                Nom = (string)record[nameof(Logement.Nom)],
                Prix = (float)record[nameof(Logement.Prix)],
                Adresse_CP = (string)record[nameof(Logement.Adresse_CP)],
                Adresse_Num = (string)record[nameof(Logement.Adresse_Num)],
                Adresse_Rue = (string)record[nameof(Logement.Adresse_Rue)],
                Adresse_Pays = (string)record[nameof(Logement.Adresse_Pays)],
                Geo_Latitude = (decimal)record[nameof(Logement.Geo_Latitude)],
                Geo_Longitude = (decimal)record[nameof(Logement.Geo_Longitude)],
                Description_Courte = (string)record[nameof(Logement.Description_Courte)],
                Description_Longue = (string)record[nameof(Logement.Description_Longue)],
                Nombre_Chambres = (int)record[nameof(Logement.Nombre_Chambres)],
                Nombre_Pieces = (int)record[nameof(Logement.Nombre_Pieces)],

            };

        }




    }
}
