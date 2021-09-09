using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Modul4HW5.Models;

namespace Modul4HW5.DataAccess.EntityConfigs
{
    public class EmployeeConfig : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasKey(a => a.EmployeeId);
            builder.Property(a => a.EmployeeId).IsRequired().ValueGeneratedOnAdd();
            builder.Property(b => b.FirstName).HasColumnType("nvarchar").HasMaxLength(50).IsRequired();
            builder.Property(c => c.LastName).HasColumnType("nvarchar").HasMaxLength(50).IsRequired();
            builder.Property(d => d.HiredData).HasColumnType("datetime2").HasMaxLength(7).IsRequired();
            builder.Property(e => e.DataOfBirth).HasColumnType("date");
            builder.HasOne(f => f.Office)
                .WithMany(f => f.Employes)
                .HasForeignKey(f => f.OfficeId)
                .OnDelete(DeleteBehavior.Cascade)
                .IsRequired();
            builder.HasOne(g => g.Title)
                .WithMany(g => g.Employes)
                .HasForeignKey(g => g.TitleId)
                .OnDelete(DeleteBehavior.Cascade)
                .IsRequired();

            builder.HasData(new List<Employee>()
            {
                new Employee()
                {
                    EmployeeId = 1,
                    FirstName = "Tatur",
                    LastName = " ",
                    DataOfBirth = new DateTime(2001, 01, 01),
                    HiredData = new DateTime(2019, 09, 09),
                    OfficeId = 1,
                    TitleId = 1
                },
                new Employee
                {
                    EmployeeId = 2,
                    FirstName = "Vlad",
                    LastName = "Vladov",
                    DataOfBirth = new DateTime(1999, 10, 13),
                    HiredData = new DateTime(2020, 1, 3),
                    OfficeId = 2,
                    TitleId = 2
                },

                new Employee
                {
                    EmployeeId = 3,
                    FirstName = "Ivan",
                    LastName = "Stepanov",
                    DataOfBirth = new DateTime(1990, 5, 4),
                    HiredData = new DateTime(2020, 1, 30),
                    OfficeId = 3,
                    TitleId = 3
                },

                new Employee
                {
                    EmployeeId = 4,
                    FirstName = "Mark",
                    LastName = "Fedorov",
                    DataOfBirth = new DateTime(1954, 7, 18),
                    HiredData = new DateTime(2000, 6, 6),
                    OfficeId = 4,
                    TitleId = 4
                },
                new Employee
                {
                    EmployeeId = 5,
                    FirstName = "Tom",
                    LastName = "Black",
                    DataOfBirth = new DateTime(1968, 11, 15),
                    HiredData = new DateTime(2010, 6, 6),
                    OfficeId = 5,
                    TitleId = 5
                },
            });
        }
    }
}
