using BLL = EcoTravel_MB_BLL.Entities;
using DAL = EcoTravel_MB_DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoTravel_MB_BLL.Mapper
{

    static class Mapper
    {
 
        #region Mapper Annulation
        public static BLL.Annulation ToBLL(this DAL.Annulation entity)
        {
            if (entity is null) return null;
            return new BLL.Annulation()
            {
                IdReservation = entity.IdReservation,
                Date_annulation = entity.Date_annulation,
                Proprio_annul = entity.Proprio_annul,
                IdClient = entity.IdClient
            };
        }

        public static DAL.Annulation ToDAL(this BLL.Annulation entity)
        {
            if (entity is null) return null;
            return new DAL.Annulation()
            {
                IdReservation = entity.IdReservation,
                Date_annulation = entity.Date_annulation,
                Proprio_annul = entity.Proprio_annul,
                IdClient = entity.IdClient
            };
        }
        #endregion

        #region Mapper Avis
        public static BLL.Avis ToBLL(this DAL.Avis entity)
        {
            if (entity is null) return null;
            return new BLL.Avis()
            {
                IdAvis = entity.IdAvis,
                Notes = entity.Notes,
                Commentaire = entity.Commentaire,
                Categorie_User = entity.Categorie_User
            };
        }

        public static DAL.Avis ToDAL(this BLL.Avis entity)
        {
            if (entity is null) return null;
            return new DAL.Avis()
            {
                IdAvis = entity.IdAvis,
                Notes = entity.Notes,
                Commentaire = entity.Commentaire,
                Categorie_User = entity.Categorie_User
            };
        }
        #endregion

        #region Mapper Client
        public static BLL.Client ToBLL(this DAL.Client entity)
        {
            if (entity is null) return null;
            return new BLL.Client()
            {
                IdClient = entity.IdClient,
                Nom = entity.Nom,
                Prénom = entity.Prénom,
                Email = entity.Email,
                Pays = entity.Pays,
                Telephone = entity.Telephone,
                Password = entity.Password
            };
        }

        public static DAL.Client ToDAL(this BLL.Client entity)
        {
            if (entity is null) return null;
            return new DAL.Client()
            {
                IdClient = entity.IdClient,
                Nom = entity.Nom,
                Prénom = entity.Prénom,
                Email = entity.Email,
                Pays = entity.Pays,
                Telephone = entity.Telephone,
                Password = entity.Password
            };
        }
        #endregion

        #region Mapper Indisponibilite
        public static BLL.Indisponibilite ToBLL(this DAL.Indisponibilite entity)
        {
            if (entity is null) return null;
            return new BLL.Indisponibilite()
            {
                IdIndisponible = entity.IdIndisponible,
                Date_debut = entity.Date_debut,
                Date_fin = entity.Date_fin,
                IdLogement = entity.IdLogement
            };
        }

        public static DAL.Indisponibilite ToDAL(this BLL.Indisponibilite entity)
        {
            if (entity is null) return null;
            return new DAL.Indisponibilite()
            {
                IdIndisponible = entity.IdIndisponible,
                Date_debut = entity.Date_debut,
                Date_fin = entity.Date_fin,
                IdLogement = entity.IdLogement
            };
        }
        #endregion

        #region Mapper Logement
        public static BLL.Logement ToBLL(this DAL.Logement entity)
        {
            if (entity is null) return null;
            return new BLL.Logement()
            {
                IdLogement = entity.IdLogement,
                Nom = entity.Nom,
                Prix = entity.Prix,
                Adresse_CP = entity.Adresse_CP,
                Adresse_Num = entity.Adresse_Num,
                Adresse_Rue = entity.Adresse_Rue,
                Adresse_Pays = entity.Adresse_Pays,
                Geo_Latitude = entity.Geo_Latitude,
                Geo_Longitude = entity.Geo_Longitude,
                Description_Courte = entity.Description_Courte,
                Description_Longue = entity.Description_Longue,
                Nombre_Chambres = entity.Nombre_Chambres,
                Nombre_Pieces = entity.Nombre_Pieces,
                Capacity_NbreMaxPersonnes = entity.Capacity_NbreMaxPersonnes,
                Nbre_SDB = entity.Nbre_SDB,
                Nbre_WC = entity.Nbre_WC,
                Balcon = entity.Balcon,
                Air_Conditionning = entity.Air_Conditionning,
                Wifi = entity.Wifi,
                Mini_Bar = entity.Mini_Bar,
                Animaux_accepted = entity.Animaux_accepted,
                Piscine = entity.Piscine,
                Voiturier = entity.Voiturier,
                Room_Service = entity.Room_Service



            };
        }

        public static DAL.Logement ToDAL(this BLL.Logement entity)
        {
            if (entity is null) return null;
            return new DAL.Logement()
            {
                IdLogement = entity.IdLogement,
                Nom = entity.Nom,
                Prix = entity.Prix,
                Adresse_CP = entity.Adresse_CP,
                Adresse_Num = entity.Adresse_Num,
                Adresse_Rue = entity.Adresse_Rue,
                Adresse_Pays = entity.Adresse_Pays,
                Geo_Latitude = entity.Geo_Latitude,
                Geo_Longitude = entity.Geo_Longitude,
                Description_Courte = entity.Description_Courte,
                Description_Longue = entity.Description_Longue,
                Nombre_Chambres = entity.Nombre_Chambres,
                Nombre_Pieces = entity.Nombre_Pieces,
                Capacity_NbreMaxPersonnes = entity.Capacity_NbreMaxPersonnes,
                Nbre_SDB = entity.Nbre_SDB,
                Nbre_WC = entity.Nbre_WC,
                Balcon = entity.Balcon,
                Air_Conditionning = entity.Air_Conditionning,
                Wifi = entity.Wifi,
                Mini_Bar = entity.Mini_Bar,
                Animaux_accepted = entity.Animaux_accepted,
                Piscine = entity.Piscine,
                Voiturier = entity.Voiturier,
                Room_Service = entity.Room_Service
            };
        }
        #endregion

        #region Mapper Owner
        public static BLL.Owner ToBLL(this DAL.Owner entity)
        {
            if (entity is null) return null;
            return new BLL.Owner()
            {
                IdClient = entity.IdClient,
                Nom = entity.Nom,
                Prénom = entity.Prénom,
                Email = entity.Email,
                Pays = entity.Pays,
                Telephone = entity.Telephone,
                Password = entity.Password
            };
        }

        public static DAL.Owner ToDAL(this BLL.Owner entity)
        {
            if (entity is null) return null;
            return new DAL.Owner()
            {
                IdClient = entity.IdClient,
                Nom = entity.Nom,
                Prénom = entity.Prénom,
                Email = entity.Email,
                Pays = entity.Pays,
                Telephone = entity.Telephone,
                Password = entity.Password
            };
        }
        #endregion

        #region Mapper Photo
        public static BLL.Photo ToBLL(this DAL.Photo entity)
        {
            if (entity is null) return null;
            return new BLL.Photo()
            {
                IdPhoto = entity.IdPhoto,
                Description = entity.Description,
                Image = entity.Image,
                IdLogement = entity.IdLogement
            };
        }

        public static DAL.Photo ToDAL(this BLL.Photo entity)
        {
            if (entity is null) return null;
            return new DAL.Photo()
            {
                IdPhoto = entity.IdPhoto,
                Description = entity.Description,
                Image = entity.Image,
                IdLogement = entity.IdLogement
            };
        }
        #endregion
        
        #region Mapper Reservation
        public static BLL.Reservation ToBLL(this DAL.Reservation entity)
        {
            if (entity is null) return null;
            return new BLL.Reservation()
            {
                IdReservation = entity.IdReservation,
                Frais_Sejour = entity.Frais_Sejour,
                Taxe_Sejour = entity.Taxe_Sejour,
                Assurance_annulation = entity.Assurance_annulation,
                IdAvis = entity.IdAvis,
                IdIndisponibilite = entity.IdIndisponibilite,
                IdLogement = entity.IdLogement,
                IdClient = entity.IdClient,
                Date_debut = entity.Date_debut,
                Date_fin = entity.Date_fin

            };
        }

        public static DAL.Reservation ToDAL(this BLL.Reservation entity)
        {
            if (entity is null) return null;
            return new DAL.Reservation()
            {
                IdReservation = entity.IdReservation,
                Frais_Sejour = entity.Frais_Sejour,
                Taxe_Sejour = entity.Taxe_Sejour,
                Assurance_annulation = entity.Assurance_annulation,
                IdAvis = entity.IdAvis,
                IdIndisponibilite = entity.IdIndisponibilite,
                IdLogement = entity.IdLogement,
                IdClient = entity.IdClient,
                Date_debut = entity.Date_debut,
                Date_fin = entity.Date_fin
            };
        }
        #endregion

        #region Mapper Type_Logement
        public static BLL.Type_Logement ToBLL(this DAL.Type_Logement entity)
        {
            if (entity is null) return null;
            return new BLL.Type_Logement()
            {
                IdType = entity.IdType,
                Description = entity.Description,
                Type = entity.Type
             
            };
        }

        public static DAL.Type_Logement ToDAL(this BLL.Type_Logement entity)
        {
            if (entity is null) return null;
            return new DAL.Type_Logement()
            {
                IdType = entity.IdType,
                Description = entity.Description,
                Type = entity.Type
            };
        }
        #endregion

    }
}
