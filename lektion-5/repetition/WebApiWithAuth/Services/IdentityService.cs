using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiWithAuth.Data;
using WebApiWithAuth.Models;

namespace WebApiWithAuth.Services
{
    public class IdentityService : IIdentityService
    {
        private readonly SqlDbContext _context;

        public IdentityService(SqlDbContext context)
        {
            _context = context;
        }

        public async Task<bool> CreateUserAsync(SignUpModel model)
        {
            if (!_context.Users.Any(user => user.Email == model.Email))
            {
                try
                {
                    var user = new User()
                    {
                        FirstName = model.FirstName,
                        LastName = model.LastName,
                        Email = model.Email
                    };
                    user.CreatePasswordWithHash(model.Password);
                    _context.Users.Add(user);
                    await _context.SaveChangesAsync();

                    return true;
                }
                catch { }
            }

            return false;
        }

        public async Task<SignInResponseModel> SignInAsync(string email, string password)
        {

            try
            {
                var user = await _context.Users.FirstOrDefaultAsync(user => user.Email == email);

                if (user != null)
                {
                    try
                    {
                        if(user.ValidatePasswordHash(password))
                        {






                            return new SignInResponseModel
                            {
                                Succeeded = true,
                                Result = new SignInResponseResult
                                {
                                    Id = user.Id,
                                    Email = user.Email,
                                    AccessToken = ""
                                }
                            };
                        }
                        
                    }
                    catch { }
                }
            }
            catch { }

            return new SignInResponseModel { Succeeded = false };

        }
    }
}
