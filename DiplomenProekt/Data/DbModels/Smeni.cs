using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DiplomenProekt.Data.DbModels
{
    public class Smeni
    {
        [Key]
        public int Id { get; set; }

        public string Smqna { get; set; }
        public DateTime DateTime { get; set; }
    }
}
