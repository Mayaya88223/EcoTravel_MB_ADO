using EcoTravel_MB_COMMON.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoTravel_MB_BLL.Entities
{
    public class Logement : ILogement
    {
        public int IdLogement { get; set; }
        public string Nom { get; set; }
        public float Prix { get; set; }
        public string Adresse_CP { get; set; }
        public string Adresse_Num { get; set; }
        public string Adresse_Rue { get; set; }
        public string Adresse_Pays { get; set; }
        public decimal Geo_Latitude { get; set; }
        public decimal Geo_Longitude { get; set; }
        public string Description_Courte { get; set; }
        public string Description_Longue { get; set; }
        public int Nombre_Chambres { get; set; }
        public int Nombre_Pieces { get; set; }
        public int Capacity_NbreMaxPersonnes { get; set; }
        public int Nbre_SDB { get; set; }
        public int Nbre_WC { get; set; }
        public bool Balcon { get; set; }
        public bool Air_Conditionning { get; set; }
        public bool Wifi { get; set; }
        public bool Mini_Bar { get; set; }
        public bool Animaux_accepted { get; set; }
        public bool Piscine { get; set; }
        public bool Voiturier { get; set; }
        public bool Room_Service { get; set; }
        public string Type { get; set; }
        public int IdClient { get; set; }
        public int IdPhoto { get; set; }
        public DateTime Date_Creation { get; set; }

    }
}
