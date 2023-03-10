using EcoTravel_MB_COMMON.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoTravel_MB_DAL.Entities
{
    public class Reservation : IReservation 
    {
        public int IdReservation { get; set; }
        public float Frais_Sejour { get; set; }
        public float Taxe_Sejour { get; set; }
        public bool Assurance_annulation { get; set; }
        public int IdAvis { get; set; }
        public int IdIndisponibilite { get; set; }
        public int IdLogement { get; set; }
        public int IdClient { get; set; }
        public DateTime Date_debut { get; set; }
        public DateTime Date_fin { get; set; }
    }
}
