using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_Tuan2
{
    public class GiaoVien:Person
    {
        public GiaoVien(string id, string name, string address, string cmnd, DateTime dateofbirth, string email, string number) : base(id, name, address, cmnd, dateofbirth, email, number)
        {
        }
    }
}

