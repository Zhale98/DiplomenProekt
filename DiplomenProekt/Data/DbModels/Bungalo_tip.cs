using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DiplomenProekt.Data.DbModels
{
    public class Bungalo_tip
    {
        [Key]
        public int Id { get; set; }

        public double Legla  { get; set; }
        public double Hora { get; set; }
        public bool Hladilnik { get; set; }
        public bool Sanitaren_vazel { get; set; }
        public virtual Collection<Legla_Bungala> Legla_Bungalas { get; set; }

    }
}
