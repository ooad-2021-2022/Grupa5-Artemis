﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GoldenLilies.Models
{
    public class Fotografija
    {
        [Key]
        private int ID { get; set; }
        private string putanja { get; set; }
        [ForeignKey("Korisnik")]
        private int korisnikID { get; set; }
        [ForeignKey("Atrakcija")]
        private int atrakcijaID { get; set; }
        private bool verifikovano { get; set; }

        private Korisnik korisnik { get; set; }
        private Atrakcija atrakcija { get; set; }

        public Fotografija() { }
    }
}