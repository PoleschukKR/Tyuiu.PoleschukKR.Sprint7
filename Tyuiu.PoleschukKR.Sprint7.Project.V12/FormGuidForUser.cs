﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tyuiu.PoleschukKR.Sprint7.Project.V12
{
    public partial class FormGuidForUser : Form
    {
        public FormGuidForUser()
        {
            InitializeComponent();
        }

        private void ButtonExitFromGuidForUser_PKR_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonExitFromGuidForUser_PKR_MouseEnter(object sender, EventArgs e)
        {
            buttonExitFromGuidForUser_PKR.BackColor = Color.Red;
        }

        private void ButtonExitFromGuidForUser_PKR_MouseDown(object sender, MouseEventArgs e)
        {
            buttonExitFromGuidForUser_PKR.BackColor = Color.Red;

        }

        private void ButtonExitFromGuidForUser_PKR_MouseLeave(object sender, EventArgs e)
        {
            buttonExitFromGuidForUser_PKR.BackColor = Color.FromArgb(181, 181, 179);

        }

        private void TextBoxGuidForUser_PKR_Enter(object sender, EventArgs e)
        {
            (sender as TextBox).SelectionStart = 0;
        }

        private void FormGuidForUser_Load(object sender, EventArgs e)
        {
            
            textBoxGuidForUser_PKR.TabStop = false;
        }
    }
}
