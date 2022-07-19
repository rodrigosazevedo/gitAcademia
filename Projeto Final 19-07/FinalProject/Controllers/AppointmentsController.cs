using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FinalProject.Data;
using FinalProject.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FinalProject.Controllers
{
    public class AppointmentsController : Controller
    {
        private readonly ApplicationDbContext _context;

        // Uso do UserManager para que a lógica necessária para obter o ID do usuário logado funcione,
        // já que isso será usado no método para criação de consultas pelo usuário
        private readonly UserManager<Person> _userManager;

        public AppointmentsController(
        ApplicationDbContext context,
        UserManager<Person> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // GET: Appointments - Utilizado para pegar todos as Consultas do banco de dados e passá-las para uma lista, que será 
        // exibida na página de Consultas
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.AppointmentSlots.Include(a => a.Doctor).Include(a => a.Exam).Include(a => a.Patient);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Appointments/Create - Utilizado para pegar todos os registros necessários para popular os selects da página de
        // criação de consultas a partir do banco de dados.
        public IActionResult Create()
        {
            ViewData["ExamId"] = new SelectList(_context.Exams, "Id", "ExamDescription");
            ViewData["DoctorId"] = new SelectList(_context.Doctors, "Id", "FullName");
            ViewData["PatientId"] = new SelectList(_context.Patients, "Id", "FullName");
            return View();
        }

        // POST: Appointments/Create - Método disparado pelo botão "Criar" na tela de criação de consultas. Pega os valores passados e 
        // cria um novo modelo, que então será salvo no banco de dados. O BIND é utilizado como forma de segurança
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Start,End,DoctorId,PatientId,ExamId")] AppointmentSlot appointmentSlot)
        {
            if (ModelState.IsValid)
            {
                _context.Add(appointmentSlot);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            ViewData["DoctorId"] = new SelectList(_context.Doctors, "Id", "FullName", appointmentSlot.DoctorId);
            ViewData["ExamId"] = new SelectList(_context.Exams, "Id", "ExamDescription", appointmentSlot.ExamId);
            ViewData["PatientId"] = new SelectList(_context.Patients, "Id", "FullName", appointmentSlot.PatientId);
            return View(appointmentSlot);
        }

        // GET: Appointments/UserAppointment - Método customizado para que o usuário consiga marcar consultas atribuídas
        // automaticamente ao seu perfil. Utiliza o userManager para pegar o ID do user logado. Também popula os selects conforme
        // necessário.
        public async Task<IActionResult> UserAppointmentAsync()
        { 
            var user = await _userManager.GetUserAsync(User);
            
            if (user == null)
            {
                return NotFound();
            }

            var userId = await _userManager.GetUserIdAsync(user);

            ViewData["PatientId"] = userId;
            ViewData["ExamId"] = new SelectList(_context.Exams, "Id", "ExamDescription");
            ViewData["DoctorId"] = new SelectList(_context.Doctors, "Id", "FullName");
            return View();
        }

        // POST: Appointments/UserAppointment - Método disparado pelo botão "Marcar" na tela de marcar consulta (pelo usuário). Pega os
        // valores passados, cria um modelo e salva no banco de dados. O BIND é utilizado como forma de segurança
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateUserAppointment([Bind("Id,Start,End,DoctorId,PatientId,ExamId")] AppointmentSlot appointmentSlot)
        {
            if (ModelState.IsValid)
            {
               _context.Add(appointmentSlot);
               await _context.SaveChangesAsync();
               return RedirectToAction(nameof(Index));
            }

            var user = await _userManager.GetUserAsync(User);
            var userId = await _userManager.GetUserIdAsync(user);

            ViewData["PatientId"] = userId;

            ViewData["DoctorId"] = new SelectList(_context.Doctors, "Id", "FullName", appointmentSlot.DoctorId);
            ViewData["ExamId"] = new SelectList(_context.Exams, "Id", "ExamDescription", appointmentSlot.ExamId);

            return View(appointmentSlot);
        }

        // GET: Appointments/Edit - Utilizado para pegar o ID da consulta selecionada e todos os registros necessários 
        // para popular os selects da página de edição de consultas a partir do banco de dados. 
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.AppointmentSlots == null)
            {
                return NotFound();
            }

            var appointmentSlot = await _context.AppointmentSlots.FindAsync(id);
            if (appointmentSlot == null)
            {
                return NotFound();
            }
            ViewData["DoctorId"] = new SelectList(_context.Doctors, "Id", "FullName", appointmentSlot.DoctorId);
            ViewData["ExamId"] = new SelectList(_context.Exams, "Id", "ExamDescription", appointmentSlot.ExamId);
            ViewData["PatientId"] = new SelectList(_context.Patients, "Id", "FullName", appointmentSlot.PatientId);
            return View(appointmentSlot);
        }

        // POST: Appointments/Edit - Método disparado pelo botão "Salvar" na tela de edição de consultas. Pega os valores passados e 
        // cria um novo modelo, que então é usado para atualizar o registro no banco de dados. O BIND é utilizado como forma de segurança
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Start,End,IsAvailable,DoctorId,PatientId,ExamId")] AppointmentSlot appointmentSlot)
        {
            if (id != appointmentSlot.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(appointmentSlot);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AppointmentSlotExists(appointmentSlot.Id))
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
            ViewData["DoctorId"] = new SelectList(_context.Doctors, "Id", "FullName", appointmentSlot.DoctorId);
            ViewData["ExamId"] = new SelectList(_context.Exams, "Id", "ExamDescription", appointmentSlot.ExamId);
            ViewData["PatientId"] = new SelectList(_context.Patients, "Id", "FullName", appointmentSlot.PatientId);
            return View(appointmentSlot);
        }

        // GET: Appointments/Delete - Utilizado para pegar o ID da consulta selecionada e os registros associados nas outras
        // tabelas relacionadas para exibir na tela.
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.AppointmentSlots == null)
            {
                return NotFound();
            }

            var appointmentSlot = await _context.AppointmentSlots
                .Include(a => a.Doctor)
                .Include(a => a.Exam)
                .Include(a => a.Patient)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (appointmentSlot == null)
            {
                return NotFound();
            }

            return View(appointmentSlot);
        }

        // POST: Appointments/Delete - Disparado ao clicar no botão "Deletar". Utilizado para pegar o ID da consulta selecionada 
        // e os registros associados nas outras tabelas relacionadas para conseguir excluir o registro selecionado.
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.AppointmentSlots == null)
            {
                return Problem("Entity set 'ApplicationDbContext.AppointmentSlots'  is null.");
            }
            var appointmentSlot = await _context.AppointmentSlots.FindAsync(id);
            if (appointmentSlot != null)
            {
                _context.AppointmentSlots.Remove(appointmentSlot);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        // Checa se a consulta existe
        private bool AppointmentSlotExists(int id)
        {
          return (_context.AppointmentSlots?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
