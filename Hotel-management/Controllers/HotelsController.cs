using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Hotel_management.Data;
using Hotel_management.Models;
using System.Collections.ObjectModel;

namespace Hotel_management.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HotelsController : ControllerBase
    {
        private readonly Hotel_managementContext _context;

        public HotelsController(Hotel_managementContext context)
        {
            _context = context;
        }

        //Ajout des 4 chambres Types
        [HttpPost]
        [Route("AddChamber")]

        public bool AddChamber()
        {
            Chambre ch =  new Chambre();
            _context.Chambre.Add(ch);
            _context.SaveChanges();
            return true;
        }

        //Get toutes les chambres
        [HttpGet]
        [Route("Getch")]
        public List<Chambre> getch()
        {
            var chbb = _context.Chambre.ToList();
            return chbb;
        }
        //Ajout des saisons
        [HttpPost]
        [Route("AddSaison")]

        public void AddSaison(DateTime deb, DateTime end, string libelle)
        {
            Saison sa = new Saison
            {
                DateDebut = deb,
                DateFin = end,
                Libelle = libelle
            };
            _context.Saisons.Add(sa);
            _context.SaveChanges();
        }
        //Avoir les infos des saisons
        [HttpGet]
        [Route("GetSaisons")]
        public List<Saison> GetSaisons()
        {
            var sai = _context.Saisons.ToList();
            return sai;
        }
        [HttpPost]
        [Route("AddTarifs")]

        public void AddTarifs(int Prix)
        {
            
            Tarifs ta = new Tarifs
            {
                PrixCat = Prix,
               
            };
            _context.Tarifss.Add(ta);
            _context.SaveChanges();
        }

        //Get les catégorie

        [HttpGet]
        [Route("GetCategorie")]

        public List<Categorie> GetCat()
        {
            return _context.Categories.ToList();
        }
        //Tous les tarifs
        [HttpGet]
        [Route("GetTarifs")]
        public List<Tarifs> GetTarifs()
        {
            var sais = _context.Tarifss.ToList();
            return sais;
        }
        //Ajout des catégories pour les chambres
        [HttpPost]
        [Route("AddCatChambre")]

        public Categorie AddCatChambre(string libelle, int MxPers)
        {
            Categorie ca = new Categorie
            {
                libelle = libelle,
                MaxPersonne = MxPers,

            };
            _context.Categories.Add(ca);
            _context.SaveChanges();
            return ca;
        }
        //Get les chambres avec des catégrories et des prix.

        [HttpGet]
        [Route("GetFullChamberCat")]

        public Categorie GetFullChamberCat(int tf, string lb, int ch)
        {
            var cat = _context.Categories.FirstOrDefault(c=>c.libelle==lb);
            var tarf = _context.Tarifss.FirstOrDefault(x => x.PrixCat == tf);
            //création du lien pour récup les données
            ICollection<Tarifs> tft = new Collection<Tarifs>();
            ICollection<Chambre> chb =  new Collection<Chambre>();
            chb.Add(_context.Chambre.FirstOrDefault(f => f.ChambreId == ch));
            tft.Add(_context.Tarifss.FirstOrDefault(x => x.PrixCat == tf));
            cat.TarifsCat = tft;
            cat.ChambreCat = chb;
            return cat;
        }
        // GET: api/Hotels
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Hotels>>> GetHotels()
        {
          if (_context.Hotels == null)
          {
              return NotFound();
          }
            return await _context.Hotels.ToListAsync();
        }

        // GET: api/Hotels/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Hotels>> GetHotels(int id)
        {
          if (_context.Hotels == null)
          {
              return NotFound();
          }
            var hotels = await _context.Hotels.FindAsync(id);

            if (hotels == null)
            {
                return NotFound();
            }

            return hotels;
        }
        //recherche Hotel sur base des critères.
        // PUT: api/Hotels/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHotels(int id, Hotels hotels)
        {
            if (id != hotels.HotelsId)
            {
                return BadRequest();
            }

            _context.Entry(hotels).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HotelsExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Hotels
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Hotels>> PostHotels(Hotels hotels)
        {
          if (_context.Hotels == null)
          {
              return Problem("Entity set 'Hotel_managementContext.Hotels'  is null.");
          }
            _context.Hotels.Add(hotels);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetHotels", new { id = hotels.HotelsId }, hotels);
        }

        // DELETE: api/Hotels/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHotels(int id)
        {
            if (_context.Hotels == null)
            {
                return NotFound();
            }
            var hotels = await _context.Hotels.FindAsync(id);
            if (hotels == null)
            {
                return NotFound();
            }

            _context.Hotels.Remove(hotels);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool HotelsExists(int id)
        {
            return (_context.Hotels?.Any(e => e.HotelsId == id)).GetValueOrDefault();
        }
    }
}
