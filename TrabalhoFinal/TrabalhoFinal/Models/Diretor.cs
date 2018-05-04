using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TrabalhoFinal.Models
{
    public class Diretor
    {
        public Diretor()
        {
            ListaDeFilmes = new HashSet<filme>();

        }
        [Key]
        public int ID { get; set; }
        public string Photo { get; set; }
        public string Born { get; set; }
        public string Nome { get; set; }
        public string Bio { get; set; }

        public virtual ICollection<filme> ListaDeFilmes {set; get;}

    }
}