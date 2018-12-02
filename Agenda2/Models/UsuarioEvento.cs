using System;
using System.Collections.Generic;

namespace Agenda2.Models
{
    public partial class UsuarioEvento
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public int EventoId { get; set; }
    }
}
