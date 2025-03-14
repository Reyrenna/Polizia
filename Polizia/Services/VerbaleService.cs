using Microsoft.EntityFrameworkCore;
using Polizia.Models;
using Polizia.ViewModels;

namespace Polizia.Services
{
    public class VerbaleService
    {
        private readonly ApplicationDbContext _context;

        public VerbaleService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Verbale>> GetVerbale()
        {
            return await _context.Verbales.ToListAsync();
        }
        public async Task<bool> AddTipoViolazione(AddVerbaleViewModel addTipoVerbaleViewModel)
        {
            var verbale = new Verbale()
            {
                DataViolazione = addTipoVerbaleViewModel.DataViolazione,
                IndirizzoViolazione = addTipoVerbaleViewModel.IndirizzoViolazione,
                NominativoAgente = addTipoVerbaleViewModel.NominativoAgente,
                DataTrascrizioneVerbale = addTipoVerbaleViewModel.DataTrascrizioneVerbale,
                Importo = addTipoVerbaleViewModel.Importo,
                DecurtamentoPunti = (int)addTipoVerbaleViewModel.DecurtamentoPunti,
                IdAnagrafica = addTipoVerbaleViewModel.IdAnagrafica,
                IdViolazione = addTipoVerbaleViewModel.IdViolazione

            };
            _context.Verbales.Add(verbale);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteVerbale(int id)
        {
            var verbale = await _context.Verbales.FindAsync(id);
            if (verbale == null)
            {
                return false;
            }
            _context.Verbales.Remove(verbale);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
