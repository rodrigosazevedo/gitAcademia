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
        private readonly UserManager<Person> _userManager;
        private readonly SignInManager<Person> _signInManager;

        public AppointmentsController(
        ApplicationDbContext context,
        UserManager<Person> userManager,
        SignInManager<Person> signInManager)
        {
            _context = context;
            _signInManager = signInManager;
            _userManager = userManager;
        }

        // GET: Appointments
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.AppointmentSlots.Include(a => a.Doctor).Include(a => a.Exam).Include(a => a.Patient);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Appointments/Create
        public IActionResult Create()
        {
            ViewData["ExamId"] = new SelectList(_context.Exams, "Id", "ExamDescription");
            ViewData["DoctorId"] = new SelectList(_context.Doctors, "Id", "FullName");
            ViewData["PatientId"] = new SelectList(_context.Patients, "Id", "FullName");
            return View();
        }

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

        // POST: Appointments/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
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

        // GET: Appointments/Edit/5
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

        // POST: Appointments/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
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

        // GET: Appointments/Delete/5
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

        // POST: Appointments/Delete/5
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
        private bool AppointmentSlotExists(int id)
        {
          return (_context.AppointmentSlots?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
