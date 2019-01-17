using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormTest.Models
{
    public class Users
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Mobilenumber { get; set; }
        public string Address { get; set; }
        public string CPF { get; set; }
       
        public DateTimeOffset Created { private set; get; }

        public Users()
        {
            this.Created = DateTimeOffset.Now;
        }

    }
}
