using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace PacientesApp.Models
{
    public class Paciente 
    {
        [HiddenInput]
        public int Codigo { get; set; }

        [Display(Name = "Nome")]
        public string Nome { get; set; }

        [Display(Name = "Sobrenome")]
        public string Sobrenome { get; set; }

        [Display(Name = "Data Nascimento")]
        [DataType(DataType.Date)]
        public DateTime DataNascimento { get; set; }

        [Display(Name = "CRM")]
        public int CRM { get; set; }

        [Display(Name = "Ano de formacao")]
        public int AnoFormacao { get; set; }

        [Display(Name = "Especializacao")]
        public string Especializacao { get; set; }

    }
}
