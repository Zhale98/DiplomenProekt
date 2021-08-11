using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DiplomenProekt.Data.DbModels
{
    public class Cenorazpis
    {
        [Key]
        public int Id { get; set; }
        public string Categoriq { get; set; }
        public int Dni { get; set; }
        public double Cena { get; set; }
        public string Smqna { get; set; }
    }
}
