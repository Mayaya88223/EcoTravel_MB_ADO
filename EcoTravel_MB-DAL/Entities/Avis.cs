﻿using EcoTravel_MB_COMMON.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoTravel_MB_DAL.Entities
{
    public class Avis : IAvis
    {
        public int IdAvis { get; set; }
        public int Notes { get; set; }
        public string Commentaire { get; set; }
        public string Categorie_User { get; set; }
    }
}
