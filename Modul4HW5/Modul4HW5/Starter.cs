using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Proxies;
using Modul4HW5.DataAccess;
using Modul4HW5.Models;
using Modul4HW5.Services.Abstractions;

namespace Modul4HW5
{
    public class Starter
    {
        private IAppConfigService _config;

        public Starter(
            IAppConfigService config)
        {
            _config = config;
        }

        public void Run()
        {
            var newEmployee = new Project()
            {
                Name = "TestProject",
                Budget = 1029384,
                StartedTime = DateTime.Now,
                Client = new Client()
                {
                    FirstName = "FirstName",
                    SecondName = "SecondName",
                    DateOfRegistration = DateTime.Now
                }
            };

            var dbOptions = new DbContextOptionsBuilder<ApplicationContext>();
            dbOptions.UseLazyLoadingProxies();
            dbOptions.UseSqlServer(_config.ConnectionString);

            using (var context = new ApplicationContext(dbOptions.Options))
            {
                var query1 = context.Employees
                    .Include(x => x.Office)
                    .Include(x => x.EmployeeProjects)
                    .ToList();

                // 2 query is timespan
                var query4 = context.Projects.Update(newEmployee);
            }
        }
    }
}
