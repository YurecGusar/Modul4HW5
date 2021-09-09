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
            var newProject = new Project()
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
            var newEmploee = new Employee()
            {
                FirstName = "TestFirstName",
                LastName = "TestLastName",
                DataOfBirth = new DateTime(1994, 09, 03),
                HiredData = DateTime.Now,
                Office = new Office()
                {
                    Location = "asdfasf",
                    Title = "saa"
                },
                Title = new Title()
                {
                    Name = "TitleName"
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

                var query2 = context.Employees.Select(t => new { Name = t.FirstName + " " + t.LastName, Experience = (DateTime.Now - t.HiredData).TotalDays / 365 }).ToArray();

                context.Clients
                    .Include(x => x.Projects)
                    .Where(x => x.ClientId == 1)
                    .FirstOrDefault()
                    .FirstName = "Ivan";
                context.SaveChanges();

                context.Add(newProject);
                context.SaveChanges();
                context.Add(newEmploee);
                context.SaveChanges();

                context.Employees.Remove(context.Employees.FirstOrDefault(x => x.FirstName == "Tatur"));
                context.SaveChanges();

                var query6 = context
                    .Employees.Select(x => x.Title)
                    .ToList()
                    .Where(x => !x.Name.Contains("a"))
                    .ToList();
            }

            Console.WriteLine("Done");
        }
    }
}
