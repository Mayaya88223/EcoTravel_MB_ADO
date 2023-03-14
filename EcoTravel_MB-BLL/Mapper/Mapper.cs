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

    }
}
