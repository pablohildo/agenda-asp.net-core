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
    public class DetailsModel : PageModel
    {
        private readonly Agenda2.Models.agendaContext _context;

        public DetailsModel(Agenda2.Models.agendaContext context)
        {
            _context = context;
        }

        public Evento Evento { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Evento = await _context.Evento.FirstOrDefaultAsync(m => m.Id == id);

            if (Evento == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
