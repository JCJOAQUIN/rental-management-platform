using RentFlow.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RentFlow.Application.Interfaces
{
    public interface IJwtTokenGenerator
    {
        // Este método recibirá al usuario y generará el string del Token
        string GenerateToken(User user);
    }
}
