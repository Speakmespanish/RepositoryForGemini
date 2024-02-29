using Microsoft.EntityFrameworkCore;
using Social.Core.Application.Interfaces.Repositories;
using Social.Core.Application.ViewModels.User;
using Social.Core.Domain.Entities;
using Social.Infrastructure.Persistence.Contexts;

namespace Social.Infrastructure.Persistence.Repositories
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        private readonly SocialContext _context;

        public UserRepository (SocialContext context) : base (context)
        {
            _context = context;
        }


        public async Task<(bool Result, string Message)> ValidateMailAsync(string mail)
        {
            try
            {
                var userToValidate = await _context.Set<User>().FirstOrDefaultAsync(x => x.Email == mail);

                if (userToValidate != null)
                {
                    var confirmed = userToValidate.IsEmailConfirmed;

                    if (confirmed)
                    {
                        return (false, "El correo existe y está confirmado");
                    }
                    else
                    {
                        return (false, "El correo existe, pero no está confirmado. Favor de confirmar");
                    }
                }
                else
                {
                    return (true, "Correo inexistente, disponible para crear usuario");
                }
            }
            catch (Exception ex)
            {
                return (false, $"Ha ocurrido un error: {ex}");
            }
        }


        public async Task<(bool Result, string Message)> CreateUserAsync (User user)
        {
            try
            {
                (bool Validate_Result, string Validate_Message) = await ValidateMailAsync(user.Email);   //Resultado devuelto del metodo ValidateMail

                if (!Validate_Result)
                {
                    return (Validate_Result, Validate_Message);
                }
                else
                {
                    //Crear usuario
                    await _context.Set<User>().AddAsync(user);
                    await _context.SaveChangesAsync();

                    //Utilizar servicio de correos aca

                    return (true, "Cuenta creada con exito. Deberas de confirmar tu cuenta en tu correo electronico");
                }
            }
            catch ( Exception ex )
            { 
                return (false, $"Ha ocurrido un error --> {ex}"); 
            }
        }


        public async Task<(bool Result, User user_loged, string Message)> LoginAsync (LoginUser_vm user)
        {
            try
            {
                (bool Validate_Result, string Validate_Message) = await ValidateMailAsync(user.Mail);

                if (!Validate_Result)
                {
                    switch (Validate_Message)
                    {
                        case "El correo existe y está confirmado":
                            var validate_user = await _context.Set<User>().FirstOrDefaultAsync(x => x.Email == user.Mail && x.Password == user.Password);

                            if (validate_user != null)
                            {
                                validate_user.Status = true;

                                return (true, validate_user, "Inicio de sesion completado");
                            }
                            else
                            {
                                return (false, null, "Contraseña o correo invalidos");
                            }

                        case "El correo existe, pero no está confirmado. Favor de confirmar":
                            return (false, null, Validate_Message);

                        default:
                            return (false, null, "Ha ocurrido un error, no se pudo iniciar sesion");
                    }
                }
                else
                {
                    return (false, null, "El correo ingresado no existe, por favor registrate");
                }
            }
            catch (Exception ex)
            {
                return (false, null, $"Ha ocurrido el siguiente error --> {ex}");
            }
        }
    }
}
