using System.Linq;
using Moises2024.EntityFramework;
using Moises2024.MultiTenancy;

namespace Moises2024.Migrations.SeedData
{
    public class DefaultTenantCreator
    {
        private readonly Moises2024DbContext _context;

        public DefaultTenantCreator(Moises2024DbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            CreateUserAndRoles();
        }

        private void CreateUserAndRoles()
        {
            //Default tenant

            var defaultTenant = _context.Tenants.FirstOrDefault(t => t.TenancyName == Tenant.DefaultTenantName);
            if (defaultTenant == null)
            {
                _context.Tenants.Add(new Tenant {TenancyName = Tenant.DefaultTenantName, Name = Tenant.DefaultTenantName});
                _context.SaveChanges();
            }
        }
    }
}
