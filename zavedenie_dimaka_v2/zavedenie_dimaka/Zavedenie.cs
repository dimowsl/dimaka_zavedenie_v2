﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zavedenie_dimaka
{
    public partial class Zavedenie : Form
    {
        public Zavedenie()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Zavedenie zavedenie = new Zavedenie();
            cenorazpis ceni =  new cenorazpis();
            ceni.Show();
            ceni.BringToFront();
        }

        private void Zavedenie_Load(object sender, EventArgs e)
        {

        }
    }
}
