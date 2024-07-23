using ElectricityCompany.Core.DTO.JWT;
using ElectricityCompany.Core.Model.JWT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricityCompany.Core.Interfaces
{
    public interface IAuthService
    {

        Task<AuthModel> RegisterAsync(RegisterUserDto model);

        Task<AuthModel> GetTokenAsync(LoginUserDto model);
        

    }
}
