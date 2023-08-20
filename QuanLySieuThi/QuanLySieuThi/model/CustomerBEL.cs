using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySieuThi.model
{
    internal class CustomerBEL
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gianhap { get; set; }
        public string Soluong { get; set; }
        public string Soluongco { get; set; }

        public AreaBEL Area { get; set; }
        public string AreaName
        {
            get { return Area.Name; }
        }
    }
}
