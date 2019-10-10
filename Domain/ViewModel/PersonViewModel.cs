using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.ViewModel
{
    public class PersonViewModel
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public string PhoneNumber { get; set; }

        public string Birthday { get; set; }

        public string SelfIntroduction { get; set; }
    }
}
