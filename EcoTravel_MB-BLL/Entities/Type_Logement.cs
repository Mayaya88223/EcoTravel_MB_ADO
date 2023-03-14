using EcoTravel_MB_COMMON.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoTravel_MB_BLL.Entities
{
    public class Type_Logement : IType_Logement
    {
        public int IdType { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }

    }
}
