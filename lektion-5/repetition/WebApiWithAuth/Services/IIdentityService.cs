using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiWithAuth.Models;

namespace WebApiWithAuth.Services
{
    public interface IIdentityService
    {
        Task<bool> CreateUserAsync(SignUpModel model);
        Task<bool> SignInAsync(string email, string password);
    }
}
