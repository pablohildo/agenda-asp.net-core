using System;
using System.Collections.Generic;

namespace Agenda2.Models
{
    public partial class Evento
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public ICollection<UsuarioEvento> Usuario_Eventos { get; set; }
    }
}
