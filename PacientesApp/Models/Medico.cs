using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace PacientesApp.Models
{
    public class Medico
    {
        [HiddenInput]
        public int Codigo { get; set; }

        [Display(Name = "Nome")]
        [MaxLength(30), Required]
        public string Nome { get; set; }

        [Display(Name = "Sobrenome")]
        [MaxLength(60), Required]
        public string Sobrenome { get; set; }

        [Display(Name = "Data Nascimento")]
        [DataType(DataType.Date), Required]
        public DateTime DataNascimento { get; set; }

        [Display(Name = "CRM")]
        [MaxLength(12), Required]
        public string CRM { get; set; }

        [Display(Name = "Ano de formacao")]
        [Required]
        public int AnoFormacao { get; set; }

        [Display(Name = "Especializacao")]
        [Required]
        public EnumEspecializacao Especializacao { get; set; }

    }
}
