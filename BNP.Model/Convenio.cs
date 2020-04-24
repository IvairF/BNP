using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace BNP.Model
{
    [Table("MOVIMENTO_MANUAL")]
    public class Movimento

    {   

        [Required, StringLength(2), Column(" DAT_MES")]
        public int DAT_MES { get; set; }

        [Required, StringLength(4), Column("DAT_ANO")]
        public int DAT_ANO { get; set; }

        [StringLength(18), Column("NUM_LANCAMENTO")]
        public long NUM_LANCAMENTO { get; set; }

        [Column("COD_PRODUTO")]
        public string COD_PRODUTO { get; set; }

        [Column("COD_CONSIF")]
        public string COD_CONSIF { get; set; }

        [Column("DES_DESCRICAO")]
        public string DES_DESCRICAO { get; set; }

        [Column("COD_USUARIO")]
        public string COD_USUARIO { get; set; }

       

    }
}
