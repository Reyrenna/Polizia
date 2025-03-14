using Microsoft.EntityFrameworkCore;
using Polizia.Models;
using Polizia.ViewModels;

namespace Polizia.Services
{
    public class TipoViolazioneService
    {
        private readonly ApplicationDbContext _context;

        public TipoViolazioneService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<TipoViolazione>> GetViolazione()
        {
            return await _context.TipoViolaziones.ToListAsync();
        }
        public async Task<bool> AddTipoViolazione(AddTipoViolazioneViewModel addTipoViolazioneViewModel)
        {
            var violazione = new TipoViolazione()
            {
                Descrizione  = addTipoViolazioneViewModel.Descrizione

            };
            _context.TipoViolaziones.Add(violazione);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteViolazione(int id)
        {
            var violazione = await _context.TipoViolaziones.FindAsync(id);
            if (violazione == null)
            {
                return false;
            }
            _context.TipoViolaziones.Remove(violazione);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
