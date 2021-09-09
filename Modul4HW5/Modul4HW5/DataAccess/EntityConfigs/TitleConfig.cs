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
    public class TitleConfig : IEntityTypeConfiguration<Title>
    {
        public void Configure(EntityTypeBuilder<Title> builder)
        {
            builder.HasKey(a => a.TitleId);
            builder.Property(a => a.TitleId).HasColumnName("TitleId").IsRequired().ValueGeneratedOnAdd();
            builder.Property(b => b.Name).HasColumnType("nvarchar").HasMaxLength(50).IsRequired();

            builder.HasData(new List<Title>()
            {
                new Title()
                {
                    TitleId = 1,
                    Name = "qwerty"
                },

                new Title()
                {
                    TitleId = 2,
                    Name = "fdsgrs"
                },

                new Title()
                {
                    TitleId = 3,
                    Name = "fdgkjjgf"
                },

                new Title()
                {
                    TitleId = 4,
                    Name = "asdfg"
                },

                new Title()
                {
                    TitleId = 5,
                    Name = "zxcvbn"
                }
            });
        }
    }
}
