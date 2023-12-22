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
    public partial class FormMSI : Form
    {
        public FormMSI()
        {
            InitializeComponent();
        }

        private void ButtonMSIGF66PictureChange_PKR_Click(object sender, EventArgs e)
        {
            if (pictureBoxMSIGF661_PKR.Visible == true && pictureBoxMSIGF662_PKR.Visible == false && pictureBoxMSIGF663_PKR.Visible == false && pictureBoxMSIGF664_PKR.Visible == false)
            {
                pictureBoxMSIGF661_PKR.Visible = false;
                pictureBoxMSIGF662_PKR.Visible = true;
            }
            else if (pictureBoxMSIGF661_PKR.Visible == false && pictureBoxMSIGF662_PKR.Visible == true && pictureBoxMSIGF663_PKR.Visible == false && pictureBoxMSIGF664_PKR.Visible == false)
            {
                pictureBoxMSIGF662_PKR.Visible = false;
                pictureBoxMSIGF663_PKR.Visible = true;
            }
            else if (pictureBoxMSIGF661_PKR.Visible == false && pictureBoxMSIGF662_PKR.Visible == false && pictureBoxMSIGF663_PKR.Visible == true && pictureBoxMSIGF664_PKR.Visible == false)
            {
                pictureBoxMSIGF663_PKR.Visible = false;
                pictureBoxMSIGF664_PKR.Visible = true;
            }
            else
            {
                pictureBoxMSIGF664_PKR.Visible = false;
                pictureBoxMSIGF661_PKR.Visible = true;
            }
        }

        private void TextBoxMSIGF66_PKR_Enter(object sender, EventArgs e)
        {
            (sender as TextBox).SelectionStart = 0;
        }

        private void ButtonMSIModern14PictureChange_PKR_Click(object sender, EventArgs e)
        {

            if (pictureBoxMSIModern141_PKR.Visible == true && pictureBoxMSIModern142_PKR.Visible == false && pictureBoxMSIModern143_PKR.Visible == false && pictureBoxMSIModern144_PKR.Visible == false)
            {
                pictureBoxMSIModern141_PKR.Visible = false;
                pictureBoxMSIModern142_PKR.Visible = true;
            }
            else if (pictureBoxMSIModern141_PKR.Visible == false && pictureBoxMSIModern142_PKR.Visible == true && pictureBoxMSIModern143_PKR.Visible == false && pictureBoxMSIModern144_PKR.Visible == false)
            {
                pictureBoxMSIModern142_PKR.Visible = false;
                pictureBoxMSIModern143_PKR.Visible = true;
            }
            else if (pictureBoxMSIModern141_PKR.Visible == false && pictureBoxMSIModern142_PKR.Visible == false && pictureBoxMSIModern143_PKR.Visible == true && pictureBoxMSIModern144_PKR.Visible == false)
            {
                pictureBoxMSIModern143_PKR.Visible = false;
                pictureBoxMSIModern144_PKR.Visible = true;
            }
            else
            {
                pictureBoxMSIModern144_PKR.Visible = false;
                pictureBoxMSIModern141_PKR.Visible = true;
            }
        }

        private void ButtonMSIGF76PictureChange_PKR_Click(object sender, EventArgs e)
        {
            if (pictureBoxMSIGF761_PKR.Visible == true && pictureBoxMSIGF762_PKR.Visible == false && pictureBoxMSIGF763_PKR.Visible == false && pictureBoxMSIGF764_PKR.Visible == false)
            {
                pictureBoxMSIGF761_PKR.Visible = false;
                pictureBoxMSIGF762_PKR.Visible = true;
            }
            else if (pictureBoxMSIGF761_PKR.Visible == false && pictureBoxMSIGF762_PKR.Visible == true && pictureBoxMSIGF763_PKR.Visible == false && pictureBoxMSIGF764_PKR.Visible == false)
            {
                pictureBoxMSIGF762_PKR.Visible = false;
                pictureBoxMSIGF763_PKR.Visible = true;
            }
            else if (pictureBoxMSIGF761_PKR.Visible == false && pictureBoxMSIGF762_PKR.Visible == false && pictureBoxMSIGF763_PKR.Visible == true && pictureBoxMSIGF764_PKR.Visible == false)
            {
                pictureBoxMSIGF763_PKR.Visible = false;
                pictureBoxMSIGF764_PKR.Visible = true;
            }
            else
            {
                pictureBoxMSIGF764_PKR.Visible = false;
                pictureBoxMSIGF761_PKR.Visible = true;
            }
        }

        private void ButtonMSIPre3_PKR_Click(object sender, EventArgs e)
        {
            if (pictureBoxMSIPre1_PKR.Visible == true && pictureBoxMSIPre2_PKR.Visible == false && pictureBoxMSIPre3_PKR.Visible == false)
            {
                pictureBoxMSIPre1_PKR.Visible = false;
                pictureBoxMSIPre2_PKR.Visible = true;
            }
            else if (pictureBoxMSIPre1_PKR.Visible == false && pictureBoxMSIPre2_PKR.Visible == true && pictureBoxMSIPre3_PKR.Visible == false)
            {
                pictureBoxMSIPre2_PKR.Visible = false;
                pictureBoxMSIPre3_PKR.Visible = true;
            }
            else 
            {
                pictureBoxMSIPre3_PKR.Visible = false;
                pictureBoxMSIPre1_PKR.Visible = true;
            }
           
        }

        private void buttonMSIGF63PictureChange_PKR_Click(object sender, EventArgs e)
        {
            if (pictureBoxMSIGF631_PKR.Visible == true && pictureBoxMSIGF632_PKR.Visible == false && pictureBoxMSIGF633_PKR.Visible == false && pictureBoxMSIGF634_PKR.Visible == false)
            {
                pictureBoxMSIGF631_PKR.Visible = false;
                pictureBoxMSIGF632_PKR.Visible = true;
            }
            else if (pictureBoxMSIGF631_PKR.Visible == false && pictureBoxMSIGF632_PKR.Visible == true && pictureBoxMSIGF633_PKR.Visible == false && pictureBoxMSIGF634_PKR.Visible == false)
            {
                pictureBoxMSIGF632_PKR.Visible = false;
                pictureBoxMSIGF633_PKR.Visible = true;
            }
            else if (pictureBoxMSIGF631_PKR.Visible == false && pictureBoxMSIGF632_PKR.Visible == false && pictureBoxMSIGF633_PKR.Visible == true && pictureBoxMSIGF634_PKR.Visible == false)
            {
                pictureBoxMSIGF633_PKR.Visible = false;
                pictureBoxMSIGF634_PKR.Visible = true;
            }
            else
            {
                pictureBoxMSIGF634_PKR.Visible = false;
                pictureBoxMSIGF631_PKR.Visible = true;
            }
        }

        private void LinkLabelMSIGF66_PKR_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo { FileName = "https://youtu.be/Yl8EQCM80_0?si=mOYs4WifyjbZhCpe", UseShellExecute = true });

        }

        private void LinkLabelMSI_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo { FileName = "https://youtu.be/z4dL5lOR24s?si=_5H1aBMIVVgqSJz9", UseShellExecute = true });
        
        }

        private void LinkLabelMSIGF76_PKR_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo { FileName = "https://youtu.be/5c3EJUyiHFk?si=RdmBSrnGtmGXPNMJ", UseShellExecute = true });
        
        }

        private void LinkLabelMSIGF63_PKR_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo { FileName = "https://youtu.be/z9YpPhNy-FA?si=fOOtkVPEwXt6ShJ7", UseShellExecute = true });
        }
    }
}
