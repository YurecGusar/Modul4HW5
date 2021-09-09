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
    public class ProjectConfig : IEntityTypeConfiguration<Project>
    {
        public void Configure(EntityTypeBuilder<Project> builder)
        {
            builder.HasKey(a => a.ProjectId);
            builder.Property(a => a.ProjectId).IsRequired().ValueGeneratedOnAdd();
            builder.Property(b => b.Name).HasColumnType("nvarchar").HasMaxLength(50).IsRequired();
            builder.Property(c => c.Budget).HasColumnType("money").IsRequired();
            builder.Property(d => d.StartedTime).HasColumnType("datetime2").HasMaxLength(7).IsRequired();
            builder.HasOne(e => e.Client)
                .WithMany(e => e.Projects)
                .HasForeignKey(e => e.ClientId)
                .OnDelete(DeleteBehavior.Cascade)
                .IsRequired();
            builder.HasData(new List<Project>()
            {
                new Project()
                {
                    ProjectId = 1,
                    Name = "First",
                    Budget = 12345,
                    StartedTime = new DateTime(2001, 02, 23),
                    ClientId = 1,
                },

                new Project()
                {
                    ProjectId = 2,
                    Name = "Second",
                    Budget = 12345,
                    StartedTime = new DateTime(2001, 09, 12),
                    ClientId = 2
                },

                new Project()
                {
                    ProjectId = 3,
                    Name = "qqq",
                    Budget = 12345,
                    StartedTime = new DateTime(2001, 10, 12),
                    ClientId = 3
                },

                new Project()
                {
                    ProjectId = 4,
                    Name = "ddd",
                    Budget = 12345,
                    StartedTime = new DateTime(2001, 05, 26),
                    ClientId = 4
                },

                new Project()
                {
                    ProjectId = 5,
                    Name = "dssfs",
                    Budget = 12345,
                    StartedTime = DateTime.Now,
                    ClientId = 5
                }
            });
        }
    }
}
