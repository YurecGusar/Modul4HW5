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
    public class ClientConfig : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
        {
            builder.HasKey(a => a.ClientId);
            builder.Property(a => a.ClientId).IsRequired().ValueGeneratedOnAdd();
            builder.Property(b => b.FirstName).HasColumnType("nvarchar").HasMaxLength(50).IsRequired();
            builder.Property(c => c.SecondName).HasColumnType("nvarchar").HasMaxLength(50).IsRequired();
            builder.Property(d => d.DataOfBirth).HasColumnType("date");
            builder.Property(e => e.DateOfRegistration).HasColumnType("datetime2").HasMaxLength(7).IsRequired();

            builder.HasData(
                new List<Client>()
                {
                    new Client()
                    {
                        ClientId = 1,
                        FirstName = "Ivan",
                        SecondName = "Budko",
                        DateOfRegistration = DateTime.Now
                    },

                    new Client()
                    {
                        ClientId = 2,
                        FirstName = "Dmitro",
                        SecondName = "Burunko",
                        DateOfRegistration = DateTime.Now
                    },

                    new Client()
                    {
                        ClientId = 3,
                        FirstName = "Yurii",
                        SecondName = "Leonov",
                        DataOfBirth = new DateTime(2001, 09, 28),
                        DateOfRegistration = DateTime.Now
                    },

                    new Client()
                    {
                        ClientId = 4,
                        FirstName = "Andry",
                        SecondName = "Kust",
                        DataOfBirth = new DateTime(2000, 11, 12),
                        DateOfRegistration = DateTime.Now
                    },

                    new Client()
                    {
                        ClientId = 5,
                        FirstName = "Misha",
                        SecondName = "Krutoy",
                        DataOfBirth = new DateTime(2014, 11, 24),
                        DateOfRegistration = DateTime.Now,
                    }
                });
        }
    }
}
