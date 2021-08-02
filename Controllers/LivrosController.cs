using Microsoft.AspNetCore.Mvc;
using TesteProgramacao.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace TesteProgramacao.Controllers
{
    public class LivrosController : Controller
    {

        private readonly Context _context;

        public LivrosController(Context context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _context.livro.ToListAsync());
        }
        [HttpGet]
        public IActionResult CriarLivro()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CriarLivro(Livro livro)
        {
            if (ModelState.IsValid)
            {
                _context.Add(livro);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            else return View(livro);
        }

        [HttpGet]
        public IActionResult AtualizarLivro(int? id)
        {
            if (id != null)
            {
                Livro livro = _context.livro.Find(id);
                return View(livro);
            }
            else return NotFound();
        }
        [HttpPost]
        public async Task<IActionResult> AtualizarLivro(int? id, Livro livro)
        {
            if (id != null)
            {
                if (ModelState.IsValid)
                {
                    _context.Update(livro);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                else return View(livro);
            }
            else return NotFound();
        }

        [HttpGet]
        public IActionResult ExcluirLivro(int? id)
        {
            if (id != null)
            {
                Livro livro = _context.livro.Find(id);
                return View(livro);
            }
            else return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> ExcluirLivro(int? id, Livro livro)
        {
            if (id != null)
            {
                _context.Remove(livro);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            else return NotFound();
        }
    }
}
