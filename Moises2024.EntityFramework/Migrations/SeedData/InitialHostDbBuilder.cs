﻿using Moises2024.EntityFramework;
using EntityFramework.DynamicFilters;

namespace Moises2024.Migrations.SeedData
{
    public class InitialHostDbBuilder
    {
        private readonly Moises2024DbContext _context;

        public InitialHostDbBuilder(Moises2024DbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            _context.DisableAllFilters();

            new DefaultEditionsCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();
        }
    }
}
