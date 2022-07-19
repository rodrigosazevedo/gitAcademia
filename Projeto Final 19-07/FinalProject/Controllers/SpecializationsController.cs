using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FinalProject.Data;
using FinalProject.Models;

namespace FinalProject.Controllers
{
    public class SpecializationsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SpecializationsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Specializations - Utilizado para pegar todas as Especializações do banco de dados e passá-las para uma lista, que será 
        // exibida na página de Especializações
        public async Task<IActionResult> Index()
        {
              return _context.Specializations != null ? 
                          View(await _context.Specializations.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.Specializations'  is null.");
        }

        // GET: Specializations/Details - Utilizado para pegar o id da especialização selecionada na lista e adquirir os valores
        // correspondentes no banco de dados, para exibí-los
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Specializations == null)
            {
                return NotFound();
            }

            var specialization = await _context.Specializations
                .FirstOrDefaultAsync(m => m.Id == id);
            if (specialization == null)
            {
                return NotFound();
            }

            return View(specialization);
        }

        // GET: Specializations/Create - Utilizado apenas para exibir a view correspondente
        public IActionResult Create()
        {
            return View();
        }

        // POST: Specializations/Create - Método disparado pelo botão "Criar" na tela de criação de especializações. Pega os valores passados e 
        // cria um novo modelo, que então será salvo no banco de dados. O BIND é utilizado como forma de segurança
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Description")] Specialization specialization)
        {
            if (ModelState.IsValid)
            {
                _context.Add(specialization);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(specialization);
        }

        // GET: Specializations/Edit - Utilizado para pegar o ID da especialização selecionada e todos os valores do banco 
        // de dados para exibir na tela de edição
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Specializations == null)
            {
                return NotFound();
            }

            var specialization = await _context.Specializations.FindAsync(id);
            if (specialization == null)
            {
                return NotFound();
            }
            return View(specialization);
        }

        // POST: Specializations/Edit - Método disparado pelo botão "Salvar" na tela de edição de especializações. Pega os valores passados e 
        // cria um novo modelo, que então é usado para atualizar o registro no banco de dados. O BIND é utilizado como forma de segurança
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Description")] Specialization specialization)
        {
            if (id != specialization.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(specialization);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SpecializationExists(specialization.Id))
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
            return View(specialization);
        }

        // GET: Specializations/Delete - Utilizado para pegar o ID da especialização relacionada para exibir na tela.
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Specializations == null)
            {
                return NotFound();
            }

            var specialization = await _context.Specializations
                .FirstOrDefaultAsync(m => m.Id == id);
            if (specialization == null)
            {
                return NotFound();
            }

            return View(specialization);
        }

        // POST: Specializations/Delete - Disparado ao clicar no botão "Deletar". Utilizado para pegar o ID da especialização selecionada 
        // para conseguir excluir o registro selecionado.
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Specializations == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Specializations'  is null.");
            }
            var specialization = await _context.Specializations.FindAsync(id);
            if (specialization != null)
            {
                _context.Specializations.Remove(specialization);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        // Checa se a especialização existe
        private bool SpecializationExists(int id)
        {
          return (_context.Specializations?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
