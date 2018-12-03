using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Agenda2.Models
{
    public partial class Evento
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        [Display(Name = "Data Inicial")]
        public DateTime DataInicio { get; set; }
        [Display(Name = "Data Final")]
        public DateTime DataFim { get; set; }
    }
}
