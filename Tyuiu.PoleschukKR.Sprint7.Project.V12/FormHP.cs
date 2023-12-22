using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tyuiu.PoleschukKR.Sprint7.Project.V12
{
    public partial class FormHP : Form
    {
        public FormHP()
        {
            InitializeComponent();
        }

        private void ButtonHPEnvyPictureChange_PKR_Click(object sender, EventArgs e)
        {
            if (pictureBoxHPEnvy1_PKR.Visible == true && pictureBoxHPEnvy2_PKR.Visible == false && pictureBoxHPEnvy3_PKR.Visible == false)
            {
                pictureBoxHPEnvy1_PKR.Visible = false;
                pictureBoxHPEnvy2_PKR.Visible = true;
            }
            else if (pictureBoxHPEnvy1_PKR.Visible == false && pictureBoxHPEnvy2_PKR.Visible == true && pictureBoxHPEnvy3_PKR.Visible == false)
            {
                pictureBoxHPEnvy2_PKR.Visible = false;
                pictureBoxHPEnvy3_PKR.Visible = true;
            }
            else
            {
                pictureBoxHPEnvy3_PKR.Visible = false;
                pictureBoxHPEnvy1_PKR.Visible = true;
            }
        }

        private void TextBoxHPEnvy_PKR_Enter(object sender, EventArgs e)
        {
            (sender as TextBox).SelectionStart = 0;
        }

        private void ButtonHPSpecPictureChange_PKR_Click(object sender, EventArgs e)
        {
            if (pictureBoxHPSpec1_PKR.Visible == true && pictureBoxHPSpec2_PKR.Visible == false && pictureBoxHPSpec3_PKR.Visible == false)
            {
                pictureBoxHPSpec1_PKR.Visible = false;
                pictureBoxHPSpec2_PKR.Visible = true;
            }
            else if (pictureBoxHPSpec1_PKR.Visible == false && pictureBoxHPSpec2_PKR.Visible == true && pictureBoxHPSpec3_PKR.Visible == false)
            {
                pictureBoxHPSpec2_PKR.Visible = false;
                pictureBoxHPSpec3_PKR.Visible = true;
            }
            else
            {
                pictureBoxHPSpec3_PKR.Visible = false;
                pictureBoxHPSpec1_PKR.Visible = true;
            }
        }

        private void ButtonHPVicPictureChange_PKR_Click(object sender, EventArgs e)
        {
            if (pictureBoxHPVic1_PKR.Visible == true && pictureBoxHPVic2_PKR.Visible == false && pictureBoxHPVic3_PKR.Visible == false)
            {
                pictureBoxHPVic1_PKR.Visible = false;
                pictureBoxHPVic2_PKR.Visible = true;
            }
            else if (pictureBoxHPVic1_PKR.Visible == false && pictureBoxHPVic2_PKR.Visible == true && pictureBoxHPVic3_PKR.Visible == false)
            {
                pictureBoxHPVic2_PKR.Visible = false;
                pictureBoxHPVic3_PKR.Visible = true;
            }
            else
            {
                pictureBoxHPVic3_PKR.Visible = false;
                pictureBoxHPVic1_PKR.Visible = true;
            }
        }

        private void LinkLabelHPEnvy_PKR_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo { FileName = "https://youtu.be/CrAt0RVMiTY?si=SFOMjoFSnqOvaBpV", UseShellExecute = true });
        

        }

        private void LinkLabelHPSpec_PKR_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo { FileName = "https://youtu.be/uQ2s9u-n4B8?si=nFIG_m4dC3mU1dzy", UseShellExecute = true });

        }

        private void LinkLabelHPVic_PKR_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo { FileName = "https://youtu.be/PtVB263hy10?si=f4FYBDIKgFKx47Ni", UseShellExecute = true });

        }
    }
}
