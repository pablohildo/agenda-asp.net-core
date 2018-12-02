using System;
using System.Collections.Generic;

namespace Agenda2.Models
{
    public partial class Usuario
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public ICollection<UsuarioEvento> Usuario_Eventos { get; set; }
    }
}
