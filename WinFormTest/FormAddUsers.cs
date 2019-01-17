using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormTest.Models;

namespace WinFormTest
{
    public partial class FormAddUsers : Form
    {
        public FormAddUsers()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MyContext context = new MyContext();

            Users user = new Users();
            user.Name = txtname.Text;
            user.Email = txtemail.Text;
            user.Mobilenumber = txtMobileNumber.Text;
            user.Address = txtAddress.Text;
            user.CPF = txtCpf.Text;

            context.Users.Add(user);
            context.SaveChanges();

            this.Dispose();
        }
    }
}
