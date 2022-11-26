using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context : IdentityDbContext<AppUser, AppRole, int>
    {
        protected override void OnConfiguring
        (DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server= LAPTOP-V0DLGIOL" + "\\MSSQLSERVER02;database=Proje;integrated security=true;");
        }

        public DbSet<AnaSayfa> AnaSayfas { get; set; }
        public DbSet<YonetimUye> yonetimUyes { get; set; }
        public DbSet<Hakkimizda> Hakkimizdas { get; set; }
       

    }
}
