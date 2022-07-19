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

        // Uso do UserManager e do UserStore para que a lógica de registrar o doutor como um usuário do sistema
        // ao terminar de criar o modelo
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

        // GET: DoctorController - Utilizado para pegar todos os Doutores do banco de dados e passá-los para uma lista, que será 
        // exibida na página de Doutores 
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Doctors.Include(e => e.Specialization);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: DoctorController/Details - Utilizado para pegar o id do doutor selecionado na lista e adquirir os valores
        // correspondentes no banco de dados, para exibí-los
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
        // GET: DoctorController/Create - Utilizado para pegar todos os registros necessários para popular o select de Especializações
        // na tela de criação de doutores
        public IActionResult Create()
        {
            ViewData["SpecializationId"] = new SelectList(_context.Specializations, "Id", "Description");
            return View();
        }

        // POST: DoctorController/Create - Método disparado pelo botão "Criar" na tela de criação de doutores. Pega os valores passados e 
        // cria um novo modelo, que então será salvo no banco de dados. O BIND é utilizado como forma de segurança
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

        // GET: DoctorController/Edit - Utilizado para pegar o ID do doutor selecionado e todos os registros necessários 
        // para popular o select de especializações da página de edição de doutores a partir do banco de dados. 
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

        // ----- MÉTODO COM ERRO - NÃO ESTÁ PASSANDO OS VALORES PARA O BANCO DE DADOS -----
        // POST: DoctorController/Edit - Método disparado pelo botão "Salvar" na tela de edição de doutores. Pega os valores passados e 
        // cria um novo modelo, que então é usado para atualizar o registro no banco de dados. O BIND é utilizado como forma de segurança
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

        // Checa se o doutor existe
        private bool DoctorExists(string id)
        {
            return (_context.Doctors?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
