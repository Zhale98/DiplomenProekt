using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DiplomenProekt.Data.DbModels
{
    public class Legla_Bungala
    {
        [Key]
        public int Id { get; set; }
       
        public int Bungalo_tip_id { get; set; }
        public  int Vid_leglo_id{ get; set; }
        [ForeignKey(nameof(Bungalo_tip_id))]
        public Bungalo_tip Bungalo_Tip{ get; set; }
        [ForeignKey(nameof(Vid_leglo_id))]
        public Vid_leglo Vid_Leglo{ get; set; }
    }
}
