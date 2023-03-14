using EcoTravel_MB_COMMON.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoTravel_MB_BLL.Entities
{
    public class Annulation : IAnnulation
    {
        public int IdReservation { get; set; }
        public DateTime Date_annulation { get; set; }
        public bool Proprio_annul { get; set; }
        public int IdClient { get; set; }
    }
}
