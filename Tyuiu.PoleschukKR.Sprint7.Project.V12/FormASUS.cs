using System;
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
    public partial class FormASUS : Form
    {
        public FormASUS()
        {
            InitializeComponent();
        }

        private void buttonAsusRogChangePicture_PKR_Click(object sender, EventArgs e)
        {
            if (pictureBoxAsusRog1_PKR.Visible == true && pictureBoxAsusRog2_PKR.Visible == false && pictureBoxAsusRog3_PKR.Visible == false && pictureBoxAsusRog4_PKR.Visible == false)
            {
                pictureBoxAsusRog1_PKR.Visible = false;
                pictureBoxAsusRog2_PKR.Visible = true;
            }
            else if (pictureBoxAsusRog1_PKR.Visible == false && pictureBoxAsusRog2_PKR.Visible == true && pictureBoxAsusRog3_PKR.Visible == false && pictureBoxAsusRog4_PKR.Visible == false)
            {
                pictureBoxAsusRog2_PKR.Visible = false;
                pictureBoxAsusRog3_PKR.Visible = true;
            }
            else if (pictureBoxAsusRog1_PKR.Visible == false && pictureBoxAsusRog2_PKR.Visible == false && pictureBoxAsusRog3_PKR.Visible == true && pictureBoxAsusRog4_PKR.Visible == false)
            {
                pictureBoxAsusRog3_PKR.Visible = false;
                pictureBoxAsusRog4_PKR.Visible = true;
            }
            else
            {
                pictureBoxAsusRog4_PKR.Visible = false;
                pictureBoxAsusRog1_PKR.Visible = true;
            }
        }

        private void buttonAsusZenPictureChange_PKR_Click(object sender, EventArgs e)
        {
            if (pictureBoxAsusZen1_PKR.Visible == true && pictureBoxAsusZen2_PKR.Visible == false && pictureBoxAsusZen3_PKR.Visible == false && pictureBoxAsusZen4_PKR.Visible == false)
            {
                pictureBoxAsusZen1_PKR.Visible = false;
                pictureBoxAsusZen2_PKR.Visible = true;
            }
            else if (pictureBoxAsusZen1_PKR.Visible == false && pictureBoxAsusZen2_PKR.Visible == true && pictureBoxAsusZen3_PKR.Visible == false && pictureBoxAsusZen4_PKR.Visible == false)
            {
                pictureBoxAsusZen2_PKR.Visible = false;
                pictureBoxAsusZen3_PKR.Visible = true;
            }
            else if (pictureBoxAsusZen1_PKR.Visible == false && pictureBoxAsusZen2_PKR.Visible == false && pictureBoxAsusZen3_PKR.Visible == true && pictureBoxAsusZen4_PKR.Visible == false)
            {
                pictureBoxAsusZen3_PKR.Visible = false;
                pictureBoxAsusZen4_PKR.Visible = true;
            }
            else
            {
                pictureBoxAsusZen4_PKR.Visible = false;
                pictureBoxAsusZen1_PKR.Visible = true;
            }

        }

        private void buttonAsusVivo17ChangePicture_PKR_Click(object sender, EventArgs e)
        {
            if (pictureBoxAsusVivo171_PKR.Visible == true && pictureBoxAsusVivo172_PKR.Visible == false && pictureBoxAsusVivo173_PKR.Visible == false && pictureBoxAsusVivo174_PKR.Visible == false)
            {
                pictureBoxAsusVivo171_PKR.Visible = false;
                pictureBoxAsusVivo172_PKR.Visible = true;
            }
            else if (pictureBoxAsusVivo171_PKR.Visible == false && pictureBoxAsusVivo172_PKR.Visible == true && pictureBoxAsusVivo173_PKR.Visible == false && pictureBoxAsusVivo174_PKR.Visible == false)
            {
                pictureBoxAsusVivo172_PKR.Visible = false;
                pictureBoxAsusVivo173_PKR.Visible = true;
            }
            else if (pictureBoxAsusVivo171_PKR.Visible == false && pictureBoxAsusVivo172_PKR.Visible == false && pictureBoxAsusVivo173_PKR.Visible == true && pictureBoxAsusVivo174_PKR.Visible == false)
            {
                pictureBoxAsusVivo173_PKR.Visible = false;
                pictureBoxAsusVivo174_PKR.Visible = true;
            }
            else
            {
                pictureBoxAsusVivo174_PKR.Visible = false;
                pictureBoxAsusVivo171_PKR.Visible = true;
            }
        }

        private void textBoxAsusRog_PKR_Enter(object sender, EventArgs e)
        {
            (sender as TextBox).SelectionStart = 0;
        }

        private void buttonAsusVivo15PictureChange_PKR_Click(object sender, EventArgs e)
        {
            if (pictureBoxAsusVivo151_PKR.Visible == true && pictureBoxAsusVivo152_PKR.Visible == false && pictureBoxAsusVivo153_PKR.Visible == false && pictureBoxAsusVivo154_PKR.Visible == false)
            {
                pictureBoxAsusVivo151_PKR.Visible = false;
                pictureBoxAsusVivo152_PKR.Visible = true;
            }
            else if (pictureBoxAsusVivo151_PKR.Visible == false && pictureBoxAsusVivo152_PKR.Visible == true && pictureBoxAsusVivo153_PKR.Visible == false && pictureBoxAsusVivo154_PKR.Visible == false)
            {
                pictureBoxAsusVivo152_PKR.Visible = false;
                pictureBoxAsusVivo153_PKR.Visible = true;
            }
            else if (pictureBoxAsusVivo151_PKR.Visible == false && pictureBoxAsusVivo152_PKR.Visible == false && pictureBoxAsusVivo153_PKR.Visible == true && pictureBoxAsusVivo154_PKR.Visible == false)
            {
                pictureBoxAsusVivo153_PKR.Visible = false;
                pictureBoxAsusVivo154_PKR.Visible = true;
            }
            else
            {
                pictureBoxAsusVivo154_PKR.Visible = false;
                pictureBoxAsusVivo151_PKR.Visible = true;
            }
        }

        private void buttonAsusVivo16PictureChange_PKR_Click(object sender, EventArgs e)
        {
            if (pictureBoxAsusVivo161_PKR.Visible == true && pictureBoxAsusVivo162_PKR.Visible == false && pictureBoxAsusVivo163_PKR.Visible == false && pictureBoxAsusVivo164_PKR.Visible == false)
            {
                pictureBoxAsusVivo161_PKR.Visible = false;
                pictureBoxAsusVivo162_PKR.Visible = true;
            }
            else if (pictureBoxAsusVivo161_PKR.Visible == false && pictureBoxAsusVivo162_PKR.Visible == true && pictureBoxAsusVivo163_PKR.Visible == false && pictureBoxAsusVivo164_PKR.Visible == false)
            {
                pictureBoxAsusVivo162_PKR.Visible = false;
                pictureBoxAsusVivo163_PKR.Visible = true;
            }
            else if (pictureBoxAsusVivo161_PKR.Visible == false && pictureBoxAsusVivo162_PKR.Visible == false && pictureBoxAsusVivo163_PKR.Visible == true && pictureBoxAsusVivo164_PKR.Visible == false)
            {
                pictureBoxAsusVivo163_PKR.Visible = false;
                pictureBoxAsusVivo164_PKR.Visible = true;
            }
            else
            {
                pictureBoxAsusVivo164_PKR.Visible = false;
                pictureBoxAsusVivo161_PKR.Visible = true;
            }
        }
    }
}
