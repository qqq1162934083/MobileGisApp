using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DBModel.WebGeneralDB
{
    [Table("Account")]
    public class Account
    {
        [Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string AccountNumber { get; set; }

        public string Password { get; set; }

        public string Nickname { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }
    }
}
