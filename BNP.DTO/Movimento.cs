using System;
using System.Collections.Generic;
using System.Text;

namespace BNP.DTO
{
    public class Movimento
    {

        public int Id { get; set; }
        public string Nome { get; set; }
        public string NomeAbreviado { get; set; }
        public int RegistroANS { get; set; }
        public int CodCorporativo { get; set; }
        public bool isElegibilidade { get; set; }
        public bool isAtivo { get; set; }
        public int TipoConvenio { get; set; }
    }
}
