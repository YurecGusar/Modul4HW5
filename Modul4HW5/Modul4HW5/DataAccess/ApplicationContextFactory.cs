using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Modul4HW5.Services;
using Modul4HW5.Services.Abstractions;

namespace Modul4HW5.DataAccess
{
    public class ApplicationContextFactory : IDesignTimeDbContextFactory<ApplicationContext>
    {
        private AppConfigService _config = new AppConfigService();

        public ApplicationContext CreateDbContext(string[] args)
        {
            var dbOptions = new DbContextOptionsBuilder<ApplicationContext>();
            dbOptions.UseSqlServer(_config.ConnectionString);

            return new ApplicationContext(dbOptions.Options);
        }
    }
}
