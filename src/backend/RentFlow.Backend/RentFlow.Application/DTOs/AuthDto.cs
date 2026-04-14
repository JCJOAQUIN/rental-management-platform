using System;
using System.Collections.Generic;
using System.Text;

namespace RentFlow.Application.DTOs
{
    public class AuthDto
    {
        public record LoginRequest(string Email, string Password);
        public record LoginResponse(string Token, string Email);
    }
}