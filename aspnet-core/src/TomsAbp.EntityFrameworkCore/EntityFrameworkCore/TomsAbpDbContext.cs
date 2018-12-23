using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using TomsAbp.Authorization.Roles;
using TomsAbp.Authorization.Users;
using TomsAbp.MultiTenancy;
using TomsAbp.MyEntitys;

namespace TomsAbp.EntityFrameworkCore
{
    public class TomsAbpDbContext : AbpZeroDbContext<Tenant, Role, User, TomsAbpDbContext>
    {
        //上下文，增加新表的地方
        public DbSet<Person> Persons { get; set; }

        public TomsAbpDbContext(DbContextOptions<TomsAbpDbContext> options)
            : base(options)
        {
        }
    }
}
