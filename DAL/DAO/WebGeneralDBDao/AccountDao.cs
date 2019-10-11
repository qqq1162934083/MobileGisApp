using DAL.EF.WebGeneralDB;
using Domain.DBModel.WebGeneralDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DAO.WebGeneralDBDao
{
    public class AccountDao
    {
        public static Account SelectByEmail(string Email)
        {
            Account account;
            using (AppDbContext db = new AppDbContext())
            {
                account = db.accounts.AsNoTracking().FirstOrDefault(r => r.Email.Equals(Email));
            }
            return account;
        }
    }
}
