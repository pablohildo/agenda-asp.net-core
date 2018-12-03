using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Agenda2.Models;

namespace Agenda2.Pages.Eventos
{
    public class IndexModel : PageModel
    {
        private readonly Agenda2.Models.agendaContext _context;

        public IndexModel(Agenda2.Models.agendaContext context)
        {
            _context = context;
        }

        public IList<Evento> Evento { get;set; }

        public async Task OnGetAsync()
        {
            Evento = await _context.Evento.ToListAsync();
        }
    }
}
