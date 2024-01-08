using System.Linq;
using Abp.Application.Editions;
using Moises2024.Editions;
using Moises2024.EntityFramework;

namespace Moises2024.Migrations.SeedData
{
    public class DefaultEditionsCreator
    {
        private readonly Moises2024DbContext _context;

        public DefaultEditionsCreator(Moises2024DbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            CreateEditions();
        }

        private void CreateEditions()
        {
            var defaultEdition = _context.Editions.FirstOrDefault(e => e.Name == EditionManager.DefaultEditionName);
            if (defaultEdition == null)
            {
                defaultEdition = new Edition { Name = EditionManager.DefaultEditionName, DisplayName = EditionManager.DefaultEditionName };
                _context.Editions.Add(defaultEdition);
                _context.SaveChanges();

                //TODO: Add desired features to the standard edition, if wanted!
            }   
        }
    }
}