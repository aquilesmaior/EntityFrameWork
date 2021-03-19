using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCore.WebAPI.Models {
    public class Arma {
        // Arma é uma relação de 1 pra 1
        public int Id { get; set; }
        public string Nome { get; set; }
        public Heroi Heroi { get; set; }
        public int HeroiId { get; set; }
    }
}
