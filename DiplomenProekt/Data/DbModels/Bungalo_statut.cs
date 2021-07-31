using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DiplomenProekt.Data.DbModels
{
    public class Bungalo_statut
    {
        [Key]
        public int Id { get; set; }
        public string Opisanie { get; set; }
    }
}
