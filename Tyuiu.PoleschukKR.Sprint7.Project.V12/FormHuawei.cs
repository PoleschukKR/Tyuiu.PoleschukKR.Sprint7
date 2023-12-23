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
    public partial class FormHuawei : Form
    {
        // Получаем текущий экземпляр формы MainForm
        FormMain mainForm = (FormMain)Application.OpenForms["FormMain"];
        
       
        public FormHuawei()
        {
            InitializeComponent();
        }

        private void ButtonHuwMBPictureChange_PKR_Click(object sender, EventArgs e)
        {

            if (pictureBoxHuwMB151_PKR.Visible == true && pictureBoxHuwMB152_PKR.Visible == false)
            {
                pictureBoxHuwMB151_PKR.Visible = false;
                pictureBoxHuwMB152_PKR.Visible = true;
            }
            else
            {
                pictureBoxHuwMB152_PKR.Visible = false;
                pictureBoxHuwMB151_PKR.Visible = true;
            }
        }

        private void TextBoxHuwMB15_PKR_Enter(object sender, EventArgs e)
        {
            (sender as TextBox).SelectionStart = 0;
        }

        private void ButtonHuwMB14PictureChange_PKR_Click(object sender, EventArgs e)
        {
            if (pictureBoxHuwMB141_PKR.Visible == true && pictureBoxHuwMB142_PKR.Visible == false)
            {
                pictureBoxHuwMB141_PKR.Visible = false;
                pictureBoxHuwMB142_PKR.Visible = true;
            }
            else
            {
                pictureBoxHuwMB142_PKR.Visible = false;
                pictureBoxHuwMB141_PKR.Visible = true;
            }
        }

        private void ButtonHuwMBXPictureChange_PKR_Click(object sender, EventArgs e)
        {

            if (pictureBoxHuwMBX1_PKR.Visible == true && pictureBoxHuwMBX2_PKR.Visible == false && pictureBoxHuwMBX3_PKR.Visible == false)
            {
                pictureBoxHuwMBX1_PKR.Visible = false;
                pictureBoxHuwMBX2_PKR.Visible = true;
            }
            else if (pictureBoxHuwMBX1_PKR.Visible == false && pictureBoxHuwMBX2_PKR.Visible == true && pictureBoxHuwMBX3_PKR.Visible == false)
            {
                pictureBoxHuwMBX2_PKR.Visible = false;
                pictureBoxHuwMBX3_PKR.Visible = true;
            }
            else
            {
                pictureBoxHuwMBX3_PKR.Visible = false;
                pictureBoxHuwMBX1_PKR.Visible = true;
            }
        }

        private void ButtonHuwMBEPictureChange_PKR_Click(object sender, EventArgs e)
        {
            if (pictureBoxHuwMBE1_PKR.Visible == true && pictureBoxHuwMBE2_PKR.Visible == false && pictureBoxHuwMBE3_PKR.Visible == false)
            {
                pictureBoxHuwMBE1_PKR.Visible = false;
                pictureBoxHuwMBE2_PKR.Visible = true;
            }
            else if (pictureBoxHuwMBE1_PKR.Visible == false && pictureBoxHuwMBE2_PKR.Visible == true && pictureBoxHuwMBE3_PKR.Visible == false)
            {
                pictureBoxHuwMBE2_PKR.Visible = false;
                pictureBoxHuwMBE3_PKR.Visible = true;
            }
            else
            {
                pictureBoxHuwMBE3_PKR.Visible = false;
                pictureBoxHuwMBE1_PKR.Visible = true;
            }
        }

        private void LinkLabelHuwMB15_PKR_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo { FileName = "https://youtu.be/X6Y_CVZwXX0?si=IRK8V1J_SGR1LDrl", UseShellExecute = true });

        }

        private void LinkLabelHuwMB14_PKR_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo { FileName = "https://youtu.be/bFM-aKR3nBc?si=Ki5XtglNWDAe0APv", UseShellExecute = true });

        }

        private void LinkLabelHuwMBX_PKR_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo { FileName = "https://youtu.be/krGrxjmJRj8?si=s-wSipuQn-67X-59", UseShellExecute = true });
        }

        private void LinkLabelHuwMBE_PKR_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo { FileName = "https://youtu.be/GESfRXARQBg?si=DB1cSryUZBsM5NPK", UseShellExecute = true });
        }


        private void ButtonHuwMBD15Star_PKR_Click(object sender, EventArgs e)
        {
            if (pictureBoxHuwMBD151Star_PKR.Visible == true && pictureBoxHuwMBD152Star_PKR.Visible == false)
            {
                pictureBoxHuwMBD151Star_PKR.Visible = false;
                pictureBoxHuwMBD152Star_PKR.Visible = true;
            }
            else
            {
                pictureBoxHuwMBD151Star_PKR.Visible = true;
                pictureBoxHuwMBD152Star_PKR.Visible = false;
            }
            

            // Получаем доступ к listBox в  форме Main
            ListBox listBox = mainForm.listBoxStar_PKR;
            string textMBD15 = ("Huawei MateBook D15 Intel Core i5-1155G7 Цена: 63000");
            // Получаем выбранный текст из listBox
            if (listBox.Items.Contains(textMBD15))
            {
                listBox.Items.Remove(textMBD15);
            }
            else
            {
                listBox.Items.Add(textMBD15);
            }

        }
         


        private void ButtonMB14Star_PKR_Click(object sender, EventArgs e)
        {
            if (pictureBoxHuwMB141Star_PKR.Visible == true && pictureBoxHuwMB142Star_PKR.Visible == false)
            {
                pictureBoxHuwMB141Star_PKR.Visible = false;
                pictureBoxHuwMB142Star_PKR.Visible = true;
            }
            else
            {
                pictureBoxHuwMB141Star_PKR.Visible = true;
                pictureBoxHuwMB142Star_PKR.Visible = false;
            }

            // Получаем доступ к listBox в  форме Main
            ListBox listBox = mainForm.listBoxStar_PKR;
            string textMB14 = ("Huawei MateBook 14 Intel Core i5-1135G7 Цена: 63000");
            // Получаем выбранный текст из listBox
            if (listBox.Items.Contains(textMB14))
            {
                listBox.Items.Remove(textMB14);
            }
            else
            {
                listBox.Items.Add(textMB14);
            }
        }


        private void ButtonHuwMBXStar_PKR_Click(object sender, EventArgs e)
        {
            if (pictureBoxHuwMBX1Star_PKR.Visible == true && pictureBoxHuwMBX2Star_PKR.Visible == false)
            {
                pictureBoxHuwMBX1Star_PKR.Visible = false;
                pictureBoxHuwMBX2Star_PKR.Visible = true;
            }
            else
            {
                pictureBoxHuwMBX1Star_PKR.Visible = true;
                pictureBoxHuwMBX2Star_PKR.Visible = false;
            }
            // Получаем доступ к listBox в  форме Main
            ListBox listBox = mainForm.listBoxStar_PKR;
            string textMBX = ("Huawei MateBook X Pro Intel Core i7-1165G7 Цена: 100000");
            // Получаем выбранный текст из listBox
            if (listBox.Items.Contains(textMBX))
            {
                listBox.Items.Remove(textMBX);
            }
            else
            {
                listBox.Items.Add(textMBX);
            }
        }

        private void ButtonHuwMBEStar_PKR_Click(object sender, EventArgs e)
        {
            if (pictureBoxHuwMBE1Star_PKR.Visible == true && pictureBoxHuwMBE2Star_PKR.Visible == false)
            {
                pictureBoxHuwMBE1Star_PKR.Visible = false;
                pictureBoxHuwMBE2Star_PKR.Visible = true;
            }
            else
            {
                pictureBoxHuwMBE1Star_PKR.Visible = true;
                pictureBoxHuwMBE2Star_PKR.Visible = false;
            }
            // Получаем доступ к listBox в  форме Main
            ListBox listBox = mainForm.listBoxStar_PKR;
            string textMBE = ("Huawei MateBook E Go Snapdragon® 8cx Gen 3 Цена: 70000");
            // Получаем выбранный текст из listBox
            if (listBox.Items.Contains(textMBE))
            {
                listBox.Items.Remove(textMBE);
            }
            else
            {
                listBox.Items.Add(textMBE);
            }
        }
    }
}
