using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using todo3.Authorization.Roles;
using todo3.Authorization.Users;
using todo3.MultiTenancy;
using todo3.Entities; // Assuming Todo entity is defined in todo3.Entities namespace

namespace todo3.EntityFrameworkCore
{
    public class todo3DbContext : AbpZeroDbContext<Tenant, Role, User, todo3DbContext>
    {
        public DbSet<Todo> Todos { get; set; } // Define DbSet for Todo entity

        public todo3DbContext(DbContextOptions<todo3DbContext> options)
            : base(options)
        {
        }
    }
}
