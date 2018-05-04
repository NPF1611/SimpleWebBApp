using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TrabalhoFinal.Models {
    public class filme {
        public filme() {
            ListaDeDiretores = new HashSet<Diretor>();
            ListaDeEscritores = new HashSet<Escritor>();
            ListaDeAtores = new HashSet<Ator>();
        }

        [Key]
        public int ID{get; set;}
        public string Photo { get; set; }
        public string Video{get; set;}
        public string Nome{get; set;}
        public string tipo{get; set;}
        
        public virtual ICollection<Diretor> ListaDeDiretores { get; set; }
        public virtual ICollection<Escritor> ListaDeEscritores { get; set; }
        public virtual ICollection<Ator> ListaDeAtores { get; set; }
    }
}