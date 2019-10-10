using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Test
{
    public class Product
    {
#pragma warning disable CS0169 // 从不使用字段“Product.name”
        private string name;
#pragma warning restore CS0169 // 从不使用字段“Product.name”

        public string Name { get; set; }

    }
}
