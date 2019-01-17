using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormTest
{
    public partial class FormListUsers : Form
    {
        public FormListUsers()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MyContext context = new MyContext();

            var list = context.Users.ToList();

            if(txtname.Text != null)
            {
                list = list.Where(x => x.Name.Contains(txtname.Text)).ToList();
            }

            if (txtcpf.Text != null)
            {
                list = list.Where(x => x.CPF.Contains(txtcpf.Text)).ToList();
            }

            dataGridView1.DataSource = list;
            
        }
    }
}
