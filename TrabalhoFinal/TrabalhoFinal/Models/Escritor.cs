﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TrabalhoFinal.Models
{
    public class Escritor
    {
        public Escritor()
        {
            ListaDeFilmes = new HashSet<filme>();

        }
        [Key]
        public int ID { get; set; }
        public string Photo { get; set; }
        public string Video { get; set; }
        public string Nome { get; set; }
        public string tipo { get; set; }

        public virtual ICollection<filme> ListaDeFilmes { get; set; }
    }
}