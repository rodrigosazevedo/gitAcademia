using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FinalProject.Data;
using FinalProject.Models;
using Microsoft.AspNetCore.Identity;

namespace FinalProject.Controllers
{
    public class DoctorsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IUserStore<Person> _userStore;
        private readonly UserManager<Person> _userManager;

        public DoctorsController(
        ApplicationDbContext context,
        UserManager<Person> userManager,
        IUserStore<Person> userStore)
        {            
            _context = context;
            _userStore = userStore;
            _userManager = userManager;
        }

        // GET: DoctorController
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Doctors.Include(e => e.Specialization);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: DoctorController/Details/5
        public async Task<IActionResult> Details(string? id)
        {
            if (id == null || _context.Doctors == null)
            {
                return NotFound();
            }

            var doctor = await _context.Doctors
                .Include(e => e.Specialization)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (doctor == null)
            {
                return NotFound();
            }

            return View(doctor);
        }

        // GET: DoctorController/Create
        public IActionResult Create()
        {
            ViewData["SpecializationId"] = new SelectList(_context.Specializations, "Id", "Description");
            return View();
        }

        // POST: DoctorController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,SpecializationId,ProfileImage,FirstName,LastName,BiologicalSex,Gender,BirthDate,MaritalStatus," +
            "RG_Number,RG_Agency,RG_ExpeditionDate,CPF,Email,PhoneNumber,CEP,State,City,District,Address,AddressNumber," +
            "Complement,CRM_Number,CRM_UF,Degree")] Doctor doctor)
        {
            if (ModelState.IsValid)
            {
                await _userStore.SetUserNameAsync(doctor, doctor.Email, CancellationToken.None);
                await _userManager.CreateAsync(doctor, "Senha@123");

                return RedirectToAction(nameof(Index));
            }
            ViewData["SpecializationId"] = new SelectList(_context.Specializations, "Id", "Description", doctor.SpecializationId);
            return View(doctor);
        }

        // GET: DoctorController/Edit/5
        public async Task<IActionResult> Edit(string? id)
        {
            if (id == null || _context.Doctors == null)
            {
                return NotFound();
            }

            var doctor = await _context.Doctors.FindAsync(id);
            if (doctor == null)
            {
                return NotFound();
            }
            ViewData["SpecializationId"] = new SelectList(_context.Specializations, "Id", "Description", doctor.SpecializationId);
            return View(doctor);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Id,SpecializationId,ProfileImage,FirstName,LastName,BiologicalSex,Gender,BirthDate,MaritalStatus," +
            "RG_Number,RG_Agency,RG_ExpeditionDate,CPF,Email,PhoneNumber,CEP,State,City,District,Address,AddressNumber," +
            "Complement,CRM_Number,CRM_UF,Degree")] Doctor doctor)
        {
            if (id != doctor.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                { 
                    //_context.Update(doctor);
                    //await _context.SaveChangesAsync();
                    await _userManager.UpdateAsync(doctor);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DoctorExists(doctor.Id))
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
            ViewData["SpecializationId"] = new SelectList(_context.Specializations, "Id", "Description", doctor.SpecializationId);
            return View(doctor);
        }

        private bool DoctorExists(string id)
        {
            return (_context.Doctors?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
