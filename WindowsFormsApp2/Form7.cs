using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // voltar
            Form6 form6 = new Form6();
            form6.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // contato
            Form8 form8 = new Form8();
            form8.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // sair
            Application.Exit();
        }
    }
}
