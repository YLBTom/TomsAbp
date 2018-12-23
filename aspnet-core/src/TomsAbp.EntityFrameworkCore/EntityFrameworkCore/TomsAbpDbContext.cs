using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using TomsAbp.Authorization.Roles;
using TomsAbp.Authorization.Users;
using TomsAbp.MultiTenancy;

namespace TomsAbp.EntityFrameworkCore
{
    public class TomsAbpDbContext : AbpZeroDbContext<Tenant, Role, User, TomsAbpDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public TomsAbpDbContext(DbContextOptions<TomsAbpDbContext> options)
            : base(options)
        {
        }
    }
}
