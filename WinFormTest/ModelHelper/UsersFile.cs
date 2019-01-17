using FileHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormTest.ModelHelper
{
    [DelimitedRecord("|")]
    public class UsersFile
    {
    
        public string Name { get; set; }
        public string Email { get; set; }
        public string Mobilenumber { get; set; }
        public string Address { get; set; }
        public string CPF { get; set; }
    }
}
