﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            AddNewUser form = new AddNewUser();
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LettersGame igra = new LettersGame();
            igra.Show();
        }
    }
}
