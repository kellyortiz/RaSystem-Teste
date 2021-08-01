using Microsoft.AspNetCore.Mvc;
using TesteProgramacao.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace TesteProgramacao.Controllers
{
    public class AutoresController : Controller
    {

        private readonly Context _context;

        public AutoresController(Context context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _context.autores.ToListAsync());
        }
        [HttpGet]
        public IActionResult CriarAutor()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CriarAutor(Autor autor)
        {
            if (ModelState.IsValid)
            {
                _context.Add(autor);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            else return View(autor);
        }

        [HttpGet]
        public IActionResult AtualizarAutor(int? id)
        {
            if (id != null)
            {
                Autor autor = _context.autores.Find(id);
                return View(autor);
            }
            else return NotFound();
        }
        [HttpPost]
        public async Task<IActionResult> AtualizarAutor(int? id, Autor autor)
        {
            if (id != null)
            {
                if (ModelState.IsValid)
                {
                    _context.Update(autor);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                else return View(autor);
            }
            else return NotFound();
        }

        [HttpGet]
        public IActionResult ExcluirAutor(int? id)
        {
            if (id != null)
            {
                Autor autor = _context.autores.Find(id);
                return View(autor);
            }
            else return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> ExcluirAutor(int? id, Autor autor)
        {
            if (id != null)
            {
                _context.Remove(autor);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            else return NotFound();
        }
    }
}
