// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
#nullable disable

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading;
using System.Threading.Tasks;
using FinalProject.Models;
using FinalProject.Models.Enums;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Logging;
 
namespace FinalProject.Areas.Identity.Pages.Account
{
    public class RegisterModel : PageModel
    {
        private readonly SignInManager<Person> _signInManager;
        private readonly UserManager<Person> _userManager;
        private readonly IUserStore<Person> _userStore;
        private readonly IUserEmailStore<Person> _emailStore;
        private readonly ILogger<RegisterModel> _logger;
        private readonly IEmailSender _emailSender;

        public RegisterModel(
            UserManager<Person> userManager,
            IUserStore<Person> userStore,
            SignInManager<Person> signInManager,
            ILogger<RegisterModel> logger,
            IEmailSender emailSender)
        {
            _userManager = userManager;
            _userStore = userStore;
            _emailStore = GetEmailStore();
            _signInManager = signInManager;
            _logger = logger;
            _emailSender = emailSender;
        }

        /// <summary>
        ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
        ///     directly from your code. This API may change or be removed in future releases.
        /// </summary>
        [BindProperty]
        public InputModel Input { get; set; }

        /// <summary>
        ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
        ///     directly from your code. This API may change or be removed in future releases.
        /// </summary>
        public string ReturnUrl { get; set; }

        /// <summary>
        ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
        ///     directly from your code. This API may change or be removed in future releases.
        /// </summary>
        public IList<AuthenticationScheme> ExternalLogins { get; set; }

        /// <summary>
        ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
        ///     directly from your code. This API may change or be removed in future releases.
        /// </summary>
        public class InputModel
        {
            [Required(ErrorMessage = "{0} deve ser preenchido")]
            [EmailAddress(ErrorMessage = "E-mail inválido!")]
            [Display(Name = "Email")]
            public string Email { get; set; }

            [Required(ErrorMessage = "{0} deve ser preenchido")]
            [StringLength(11, MinimumLength = 11,ErrorMessage = "{0} inválido! Deve ser composto por {1} números")]
            [RegularExpression("[0-9]+", ErrorMessage = "{0} deve conter apenas números")]
            [Display(Name = "CPF")]            
            public string CPF { get; set; }

            [Required(ErrorMessage = "{0} deve ser preenchida")]
            [StringLength(100, ErrorMessage = "{0} deve ter entre {2} e {1} caracteres", MinimumLength = 6)]
            [DataType(DataType.Password)]
            [Display(Name = "Senha")]
            public string Password { get; set; }

            [DataType(DataType.Password)]
            [Display(Name = "Confirmar senha")]
            [Compare("Password", ErrorMessage = "As senhas informadas não são iguais")]
            public string ConfirmPassword { get; set; }

            [Required(ErrorMessage = "{0} deve ser preenchido")]
            [RegularExpression("^[a-zA-Z]+(([',. -][a-zA-Z ])?[a-zA-Z]*)*$", ErrorMessage ="{0} deve conter apenas letras")]
            [StringLength(50, ErrorMessage = "{0} deve ter no máximo {1} caracteres")]
            [Display(Name = "Nome")]
            public string FirstName { get; set; }

            [Required(ErrorMessage = "{0} deve ser preenchido")]
            [RegularExpression("^[a-zA-Z]+(([',. -][a-zA-Z ])?[a-zA-Z]*)*$", ErrorMessage = "{0} deve conter apenas letras")]
            [StringLength(50, ErrorMessage = "{0} deve ter no máximo {1} caracteres")]
            [Display(Name = "Sobrenome")]
            public string LastName { get; set; }

            [Required(ErrorMessage = "{0} deve ser especificada")]
            [DisplayFormat(DataFormatString = "{0:dd/MM/yy}")]
            [Display(Name = "Data de Nascimento")]
            public DateTime BirthDate { get; set; }

            [Required(ErrorMessage = "{0} deve ser preenchido")]
            [StringLength(11, MinimumLength = 10, ErrorMessage = "{0} deve ter entre {2} e {1} números")]
            [RegularExpression("[0-9]+")]
            [Display(Name="Celular")]
            public string PhoneNumber { get; set; }

            [Required(ErrorMessage ="{0} deve ser selecionado")]
            [Display(Name = "Sexo")]
            public BiologicalSex BiologicalSex { get; set; }

            [Display(Name="Identidade de Gênero")]
            public Gender Gender { get; set; }
        }


        public async Task OnGetAsync(string returnUrl = null)
        {
            ReturnUrl = returnUrl;
            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
        }

        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            returnUrl ??= Url.Content("~/");
            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
            if (ModelState.IsValid)
            {
                var user = CreateUser();

                user.CPF = Input.CPF;
                user.FirstName = Input.FirstName;
                user.LastName = Input.LastName;
                user.BirthDate = Input.BirthDate;
                user.PhoneNumber = Input.PhoneNumber;
                user.BiologicalSex = Input.BiologicalSex;
                user.Gender = Input.Gender;

                await _userStore.SetUserNameAsync(user, Input.Email, CancellationToken.None);
                await _emailStore.SetEmailAsync(user, Input.Email, CancellationToken.None);
                var result = await _userManager.CreateAsync(user, Input.Password);

                if (result.Succeeded)
                {
                    _logger.LogInformation("Usuário criou uma nova conta com senha.");

                    var userId = await _userManager.GetUserIdAsync(user);
                    var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                    code = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code));
                    var callbackUrl = Url.Page(
                        "/Account/ConfirmEmail",
                        pageHandler: null,
                        values: new { area = "Identity", userId = userId, code = code, returnUrl = returnUrl },
                        protocol: Request.Scheme);

                    await _emailSender.SendEmailAsync(Input.Email, "Confirme seu e-mail",
                        $"Por favor confirme seu e-mail <a href='{HtmlEncoder.Default.Encode(callbackUrl)}'>clicando aqui</a>.");

                    if (_userManager.Options.SignIn.RequireConfirmedAccount)
                    {
                        return RedirectToPage("RegisterConfirmation", new { email = Input.Email, returnUrl = returnUrl });
                    }
                    else
                    {
                        await _signInManager.SignInAsync(user, isPersistent: false);
                        return LocalRedirect(returnUrl);
                    }
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }

            // If we got this far, something failed, redisplay form
            return Page();
        }

        private Patient CreateUser()
        {
            try
            {
                return Activator.CreateInstance<Patient>();
            }
            catch
            {
                throw new InvalidOperationException($"Can't create an instance of '{nameof(Patient)}'. " +
                    $"Ensure that '{nameof(Patient)}' is not an abstract class and has a parameterless constructor, or alternatively " +
                    $"override the register page in /Areas/Identity/Pages/Account/Register.cshtml");
            }
        }

        private IUserEmailStore<Person> GetEmailStore()
        {
            if (!_userManager.SupportsUserEmail)
            {
                throw new NotSupportedException("The default UI requires a user store with email support.");
            }
            return (IUserEmailStore<Person>)_userStore;
        }
    }
}
