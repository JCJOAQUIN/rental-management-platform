using System;
using System.Collections.Generic;
using System.Text;

namespace RentFlow.Domain.Entities
{
    public class User
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string PasswordHash { get; set; } = string.Empty;
        public string Role { get; set; } = "User"; // Admin, Operator, etc.
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        // Relación con el Tenant (Multitenancy)
        public Guid TenantId { get; set; }
        public Tenant? Tenant { get; set; }
    }
}
