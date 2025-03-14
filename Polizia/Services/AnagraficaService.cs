using Microsoft.EntityFrameworkCore;
using Polizia.Models;
using Polizia.ViewModels;

namespace Polizia.Services
{
    public class AnagraficaService
    {
        private readonly ApplicationDbContext _context;

        public AnagraficaService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Anagrafica>> GetAnagrafiche()
        {
            return await _context.Anagraficas.ToListAsync();
        }

        //public async Task<Anagrafica> GetAnagrafica(int id)
        //{
        //    return await _context.Anagraficas.FindAsync(id);
        //}

        public async Task<bool> AddAnagrafica(AddAnagraficaViewModel addAnagraficaViewModel)
        {
            var anagrafica = new Anagrafica()
            {
              Nome = addAnagraficaViewModel.Nome,
                Cognome = addAnagraficaViewModel.Cognome,
                Indirizzo = addAnagraficaViewModel.Indirizzo,
                Citta = addAnagraficaViewModel.Citta,
                Cap = addAnagraficaViewModel.Cap,
                CodFisc = addAnagraficaViewModel.CodFisc

            };
            _context.Anagraficas.Add(anagrafica);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteAnagrafica(int id)
        {
            var anagrafica = await _context.Anagraficas.FindAsync(id);
            if (anagrafica == null)
            {
                return false;
            }
            _context.Anagraficas.Remove(anagrafica);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
