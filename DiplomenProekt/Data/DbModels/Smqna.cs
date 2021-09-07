using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DiplomenProekt.Data.DbModels
{
    public class Smqna
    {
        [Key]
        public int Id { get; set; }

        private string smeni;

        public string GetSmeni()
        {
            return smeni;
        }

        public void SetSmeni(string value)
        {
            smeni = value;
        }

        public DateTime DateTime { get; set; }
        public DateTime Date { get; set; }

        public enum Smeni
        {
            I,
            II,
            III,
            IV,
            V,
            VI,
            VII,
            VIII

        }
    }
}



