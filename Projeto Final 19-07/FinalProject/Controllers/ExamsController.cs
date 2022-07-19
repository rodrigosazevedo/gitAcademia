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
    public class ExamsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ExamsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Exams - Utilizado para pegar todos os Exames do banco de dados e passá-los para uma lista, que será 
        // exibida na página de Consultas. Associa eles com as Especializações correspondentes.
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Exams.Include(e => e.Specialization);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Exams/Details - Utilizado para pegar o id do exame selecionado na lista e adquirir os valores
        // correspondentes no banco de dados, para exibí-los. Associa eles com as Especializações correspondentes.
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Exams == null)
            {
                return NotFound();
            }

            var exam = await _context.Exams
                .Include(e => e.Specialization)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (exam == null)
            {
                return NotFound();
            }

            return View(exam);
        }

        // GET: Exams/Create - Utilizado para pegar todos os registros necessários para popular o select de Especializações
        // na tela de criação de exames
        public IActionResult Create()
        {
            ViewData["SpecializationId"] = new SelectList(_context.Specializations, "Id", "Description");
            return View();
        }

        // POST: Exams/Create - Método disparado pelo botão "Criar" na tela de criação de exames. Pega os valores passados e 
        // cria um novo modelo, que então será salvo no banco de dados. O BIND é utilizado como forma de segurança
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,SpecializationId,ExamDescription,Duration")] Exam exam)
        {
            if (ModelState.IsValid)
            {
                _context.Add(exam);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["SpecializationId"] = new SelectList(_context.Specializations, "Id", "Description", exam.SpecializationId);
            return View(exam);
        }

        // GET: Exams/Edit - Utilizado para pegar o ID do exame selecionado e todos os registros necessários 
        // para popular o select de especializações da página de edição de exames a partir do banco de dados. 
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Exams == null)
            {
                return NotFound();
            }

            var exam = await _context.Exams.FindAsync(id);
            if (exam == null)
            {
                return NotFound();
            }
            ViewData["SpecializationId"] = new SelectList(_context.Specializations, "Id", "Description", exam.SpecializationId);
            return View(exam);
        }

        // POST: Exams/Edit - Método disparado pelo botão "Salvar" na tela de edição de exames. Pega os valores passados e 
        // cria um novo modelo, que então é usado para atualizar o registro no banco de dados. O BIND é utilizado como forma de segurança
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,SpecializationId,ExamDescription,Duration")] Exam exam)
        {
            if (id != exam.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(exam);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ExamExists(exam.Id))
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
            ViewData["SpecializationId"] = new SelectList(_context.Specializations, "Id", "Description", exam.SpecializationId);
            return View(exam);
        }

        // GET: Exams/Delete - Utilizado para pegar o ID do exame selecionado e os registros associados nas outras
        // tabelas relacionadas para exibir na tela.
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Exams == null)
            {
                return NotFound();
            }

            var exam = await _context.Exams
                .Include(e => e.Specialization)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (exam == null)
            {
                return NotFound();
            }

            return View(exam);
        }

        // POST: Exams/Delete - Disparado ao clicar no botão "Deletar". Utilizado para pegar o ID do exame selecionado
        // e os registros associados nas outras tabelas relacionadas para conseguir excluir o registro selecionado.
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Exams == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Exams'  is null.");
            }
            var exam = await _context.Exams.FindAsync(id);
            if (exam != null)
            {
                _context.Exams.Remove(exam);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        // Checa se o exame existe
        private bool ExamExists(int id)
        {
          return (_context.Exams?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
