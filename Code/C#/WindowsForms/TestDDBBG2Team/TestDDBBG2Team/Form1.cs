using System;
using System.Data;
using System.Windows.Forms;
using accesoDB;

namespace TestDDBBG2Team
{
    public partial class Form1 : Form
    {
        DataTable obj;
        Class1 acc = new Class1();

        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = obj;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            acc.Actualizar();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string query = "select * from Users";
            obj = acc.Traerporconsulta(query);
        }
    }
}
