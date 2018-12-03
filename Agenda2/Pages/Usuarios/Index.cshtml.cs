using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Agenda2.Models;

namespace Agenda2.Pages.Usuarios
{
    public class IndexModel : PageModel
    {
        private readonly Agenda2.Models.agendaContext _context;

        public IndexModel(Agenda2.Models.agendaContext context)
        {
            _context = context;
        }

        public IList<Usuario> Usuario { get;set; }

        public async Task OnGetAsync()
        {
            Usuario = await _context.Usuario.ToListAsync();
        }
    }
}
