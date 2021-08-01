using Microsoft.AspNetCore.Mvc;
using TesteProgramacao.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace TesteProgramacao.Controllers
{
    public class EditorasController : Controller
    {

        private readonly Context _context;

        public EditorasController(Context context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _context.editoras.ToListAsync());
        }
        [HttpGet]
        public IActionResult CriarEditora()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CriarEditora(Editora editora)
        {
            if (ModelState.IsValid)
            {
                _context.Add(editora);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            else return View(editora);
        }

        [HttpGet]
        public IActionResult AtualizarEditora(int? id)
        {
            if (id != null)
            {
                Editora editora = _context.editoras.Find();
                return View(editora);
            }
            else return NotFound();
        }
        [HttpPost]
        public async Task<IActionResult> AtualizarEditora(int? id, Editora editora)
        {
            if (id != null)
            {
                if (ModelState.IsValid)
                {
                    _context.Update(editora);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                else return View(editora);
            }
            else return NotFound();
        }

        [HttpGet]
        public IActionResult ExcluirEditora(int? id)
        {
            if (id != null)
            {
                Editora editora = _context.editoras.Find(id);
                return View(editora);
            }
            else return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> ExcluirEditora(int? id, Editora editora)
        {
            if (id != null)
            {
                _context.Remove(editora);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            else return NotFound();
        }
    }
}
