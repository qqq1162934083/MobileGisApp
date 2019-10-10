using Domain.DBModel.WebGeneralDB;
using Domain.ViewModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.WebGeneralDB
{
    public class AppDbContext : DbContext
    {
        public AppDbContext():base("name=WebGeneralDB")
        {
        }

        public DbSet<Account> accounts { get; set; }
    }
}
