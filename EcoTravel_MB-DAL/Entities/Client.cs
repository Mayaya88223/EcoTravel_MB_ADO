using EcoTravel_MB_COMMON.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoTravel_MB_DAL.Entities
{
    public class Client: IClient
    {
     
    //INTEGER
    public int IdClient { get; set; }
    //NVARCHAR(50)
    public string Nom { get; set; }
    //NVARCHAR(50)
    public string Prénom { get; set; }

    //NVARCHAR(50)
    public string Email { get; set; }
    //NVARCHAR(50)
    public string Pays { get; set; }
    //NVARCHAR(50)
    public string Telephone { get; set; }

    //VARBINARY(64)
    public string Password { get; set; }
      
    
}
}
