﻿using System;
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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // voltar
            Form7 form7 = new Form7();
            form7.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // sair
            Application.Exit();
        }
    }
}
