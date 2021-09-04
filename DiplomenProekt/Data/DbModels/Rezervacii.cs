using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DiplomenProekt.Data.DbModels
{
    public class Rezervacii
    {
        [Key]
        public int Id { get; set; }
        public string Smqna { get; set; }
        public string Kategoriq { get; set; }
        public int Dni { get; set; }
        public string Ime { get; set; }
        public string Familiq { get; set; }
        public int Bungalo { get; set; }
        public int Cena { get; set; }
    }
}
