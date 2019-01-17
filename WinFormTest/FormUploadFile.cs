using FileHelpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormTest.ModelHelper;
using WinFormTest.Models;

namespace WinFormTest
{
    public partial class FormUploadFile : Form
    {

        private List<UsersFile> UsersFiles;
        public FormUploadFile()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnupload_Click(object sender, EventArgs e)
        {
            var engine = new FileHelperEngine<UsersFile>();
            this.openFileDialog1.Multiselect = false;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                var result = engine.ReadFile(openFileDialog1.FileName);

                dataGridView1.DataSource = result;
                UsersFiles = result.ToList();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (UsersFiles != null)
            {
                MyContext context = new MyContext();

                context.Users.AddRange(AutoMapper.Mapper.Map<IEnumerable<Users>>(UsersFiles));
                context.SaveChanges();
            }
        }
    }
}
