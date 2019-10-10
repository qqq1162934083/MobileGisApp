using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Domain.ViewModel
{
    public class AccountViewModel
    {
        [Required(ErrorMessage ="请输入你的账号")]
        //[RegularExpression(@"\d{10}",ErrorMessage ="请输入正确格式的账号")]
        public string AccountNumber { get; set; }

        [Required(ErrorMessage = "请输入你的密码")]
        public string Password { get; set; }

        public string Nickname { get; set; }

        public string Phone { get; set; }

        public bool? AcceptAgreement { get; set; }
    }
}