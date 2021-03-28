using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.StaticFiles;
using Microsoft.EntityFrameworkCore;
using MusicShopMVC.Data;
using MusicShopMVC.Models;

namespace MusicShopMVC.Controllers
{
    public class TrompetasController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IWebHostEnvironment _hostEnvironment;

        public TrompetasController(ApplicationDbContext context, IWebHostEnvironment hostEnvironment)
        {
            _context = context;
            _hostEnvironment = hostEnvironment;
        }

        // GET: Trompetas
        public async Task<IActionResult> Index(string searchString)
        {
            // Inicio Funcion de busqueda por marca o modelo
            var trompetas = from Trompeta in _context.Trompetas.Include(t => t.Marca)
                   select Trompeta;

            if (!String.IsNullOrEmpty(searchString))
            {
                trompetas = trompetas.Where(t => t.Marca.Nombre.Contains(searchString)
                               || t.Modelo.Contains(searchString));
                return View(await trompetas.ToListAsync());
            }
            // Fin Funcion de busqueda por marca o modelo

            var applicationDbContext = _context.Trompetas.Include(t => t.Marca);

            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Trompetas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var trompeta = await _context.Trompetas
                .Include(t => t.Marca)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (trompeta == null)
            {
                return NotFound();
            }

            return View(trompeta);
        }

        // GET: Trompetas/Create
        public IActionResult Create()
        {
            ViewData["MarcaID"] = new SelectList(_context.Marcas, "ID", "Nombre");
            return View();
        }

        // POST: Trompetas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Afinacion,MarcaID,Modelo,Tipo,Material,ImagenSubir,ID")] Trompeta trompeta)
        {
            if (ModelState.IsValid)
            {
                //Guardar IMG en wwwroot/Productos/
                string wwwRootPath = _hostEnvironment.WebRootPath;
                string fileName = Path.GetFileNameWithoutExtension(trompeta.ImagenSubir.FileName);
                string extension = Path.GetExtension(trompeta.ImagenSubir.FileName);
                trompeta.NombreImagen = fileName = fileName + extension;
                string path = Path.Combine(wwwRootPath + "/Productos/", fileName);
                using (var fileStream = new FileStream(path, FileMode.Create))
                {
                    await trompeta.ImagenSubir.CopyToAsync(fileStream);
                }

                _context.Add(trompeta);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["MarcaID"] = new SelectList(_context.Marcas, "ID", "Nombre", trompeta.MarcaID);
            return View(trompeta);
        }

        // GET: Trompetas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var trompeta = await _context.Trompetas.FindAsync(id);
            if (trompeta == null)
            {
                return NotFound();
            }

            string wwwRootPath = _hostEnvironment.WebRootPath;
            string path = Path.Combine(wwwRootPath + "/Productos/", trompeta.NombreImagen);
            
            var fileProvider = new FileExtensionContentTypeProvider();

            if (!fileProvider.TryGetContentType(path, out string contentType))
            {
                return NotFound();
            }

            using (var stream = System.IO.File.OpenRead(path))
            {
                trompeta.ImagenSubir = new FormFile(stream, 0, stream.Length, null, Path.GetFileName(stream.Name))
                {
                Headers = new HeaderDictionary(),
                ContentType = contentType
                };
            }

            ViewData["MarcaID"] = new SelectList(_context.Marcas, "ID", "Nombre", trompeta.MarcaID);
            return View(trompeta);
        }

        // POST: Trompetas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Afinacion,MarcaID,Modelo,Tipo,Material,NombreImagen,ImagenSubir,ID")] Trompeta trompeta)
        {
            if (id != trompeta.ID)
            {
                return NotFound();
            }

            string wwwRootPath = _hostEnvironment.WebRootPath;
            string pathActual = Path.Combine(wwwRootPath + "/Productos/", trompeta.NombreImagen);
            
            if(trompeta.ImagenSubir != null)
            {
                string fileName = Path.GetFileNameWithoutExtension(trompeta.ImagenSubir.FileName);
                string extension = Path.GetExtension(trompeta.ImagenSubir.FileName);
                trompeta.NombreImagen = fileName = fileName + extension;
                string path = Path.Combine(wwwRootPath + "/Productos/", fileName);
                using (var fileStream = new FileStream(path, FileMode.Create))
                {
                    await trompeta.ImagenSubir.CopyToAsync(fileStream);
                }
            }

            if (ModelState.IsValid)
            {
                try
                {       
                    _context.Update(trompeta);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TrompetaExists(trompeta.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["MarcaID"] = new SelectList(_context.Marcas, "ID", "Nombre", trompeta.MarcaID);
            return View(trompeta);
        }

        // GET: Trompetas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var trompeta = await _context.Trompetas
                .Include(t => t.Marca)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (trompeta == null)
            {
                return NotFound();
            }

            return View(trompeta);
        }

        // POST: Trompetas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var trompeta = await _context.Trompetas.FindAsync(id);

            //Borrar imagen de wwwroot/Productos
            var imagePath = Path.Combine(_hostEnvironment.WebRootPath,"Productos",trompeta.NombreImagen);
            if (System.IO.File.Exists(imagePath))
                System.IO.File.Delete(imagePath);

            //Borra imagen de Db
            _context.Trompetas.Remove(trompeta);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TrompetaExists(int id)
        {
            return _context.Trompetas.Any(e => e.ID == id);
        }
    }
}
