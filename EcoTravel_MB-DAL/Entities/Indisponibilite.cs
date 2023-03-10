using EcoTravel_MB_COMMON.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoTravel_MB_DAL.Entities
{
    public class Indisponibilite : IIndisponibilite
    {
        public int IdIndisponible { get; set; }
        public DateTime Date_debut { get; set; }
        public DateTime Date_fin { get; set; }
        public int IdLogement { get; set; }

    }
}
