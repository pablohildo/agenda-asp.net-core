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
        [DataType(DataType.Date)]
        public DateTime DataInicio { get; set; }
        [Display(Name = "Data Final")]
        [DataType(DataType.Date)]
        public DateTime DataFim { get; set; }
    }
}
