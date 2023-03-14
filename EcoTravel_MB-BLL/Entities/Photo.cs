using EcoTravel_MB_COMMON.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoTravel_MB_BLL.Entities
{
    public class Photo : IPhoto
    {
        public int IdPhoto { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public int IdLogement { get; set; }
    }
}
