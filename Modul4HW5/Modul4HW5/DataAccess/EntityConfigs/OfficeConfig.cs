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
    public class OfficeConfig : IEntityTypeConfiguration<Office>
    {
        public void Configure(EntityTypeBuilder<Office> builder)
        {
            builder.HasKey(a => a.OfficeId);
            builder.Property(a => a.OfficeId).IsRequired().ValueGeneratedOnAdd();
            builder.Property(a => a.Title).HasColumnType("nvarchar").HasMaxLength(100).IsRequired();
            builder.Property(a => a.Location).HasColumnType("nvarchar").HasMaxLength(100).IsRequired();

            builder.HasData(new List<Office>()
            {
                new Office()
                {
                    OfficeId = 1,
                    Location = "asfafasf",
                    Title = "asaaaswd"
                },

                new Office()
                {
                    OfficeId = 2,
                    Location = "qwert",
                    Title = "lkgfd"
                },

                new Office()
                {
                    OfficeId = 3,
                    Location = "sss",
                    Title = "aaa"
                },

                new Office()
                {
                    OfficeId = 4,
                    Location = "ggg",
                    Title = "sddfg"
                },

                new Office()
                {
                    OfficeId = 5,
                    Location = "hgfgr",
                    Title = "vcbcvb"
                }
            });
        }
    }
}
