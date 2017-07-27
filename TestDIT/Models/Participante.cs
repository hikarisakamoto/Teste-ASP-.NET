using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DecisionIT.Models
    {
    public class Participante
        {
        public long Id { get; set; }
        // Required modfier act as notnull
        // StringLenth(x) act as varchar(x)

        [Required]
        [StringLength(4)]
        public string REG { get; set; }


        [Required]
        [StringLength(60)]
        public string COD_PART { get; set; }

        [Required]
        [StringLength(100)]
        public string NOME { get; set; }

        public short COD_PAIS { get; set; }

        [StringLength(14)]
        public string CNPJ { get; set; }

        [StringLength(11)]
        public string CPF { get; set; }

        [StringLength(14)]
        public string IE { get; set; }

        [StringLength(7)]
        public string COD_MUN { get; set; }

        [StringLength(9)]
        public string SUFRAMA { get; set; }

        [Required]
        [StringLength(60)]
        public string END { get; set; }

        [StringLength(10)]
        public string NUM { get; set; }

        [StringLength(60)]
        public string COMPL { get; set; }

        [StringLength(60)]
        public string BAIRRO { get; set; }
        }
    }