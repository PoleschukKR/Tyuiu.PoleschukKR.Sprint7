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
        // Получаем текущий экземпляр формы MainForm
        FormMain mainForm = (FormMain)Application.OpenForms["FormMain"];
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

        private void ButtonMSIGF63PictureChange_PKR_Click(object sender, EventArgs e)
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

        private void ButtonMSIGF66Star_PKR_Click(object sender, EventArgs e)
        {
            if (pictureBoxMSIGF661Star_PKR.Visible == true && pictureBoxMSIGF662Star_PKR.Visible == false)
            {
                pictureBoxMSIGF661Star_PKR.Visible = false;
                pictureBoxMSIGF662Star_PKR.Visible = true;
            }
            else
            {
                pictureBoxMSIGF661Star_PKR.Visible = true;
                pictureBoxMSIGF662Star_PKR.Visible = false;
            }

            // Получаем доступ к listBox в  форме Main
            ListBox listBox = mainForm.listBoxStar_PKR;
            string textMSIGF66 = ("MSI GF66 Katana 11UE-408XRU Intel Core i5-11400H Цена: 107000");
            // Получаем выбранный текст из listBox
            if (listBox.Items.Contains(textMSIGF66))
            {
                listBox.Items.Remove(textMSIGF66);
            }
            else
            {
                listBox.Items.Add(textMSIGF66);
            }
        }

        private void ButtonMSIModern14Star_PKR_Click(object sender, EventArgs e)
        {
            if (pictureBoxMSIModern141Star_PKR.Visible == true && pictureBoxMSIModern142Star_PKR.Visible == false)
            {
                pictureBoxMSIModern141Star_PKR.Visible = false;
                pictureBoxMSIModern142Star_PKR.Visible = true;
            }
            else
            {
                pictureBoxMSIModern141Star_PKR.Visible = true;
                pictureBoxMSIModern142Star_PKR.Visible = false;
            }

            // Получаем доступ к listBox в  форме Main
            ListBox listBox = mainForm.listBoxStar_PKR;
            string textMSIModern14 = ("MSI Modern 14 C12M-233XRU Intel Core i3-1215U Цена: 38000");
            // Получаем выбранный текст из listBox
            if (listBox.Items.Contains(textMSIModern14))
            {
                listBox.Items.Remove(textMSIModern14);
            }
            else
            {
                listBox.Items.Add(textMSIModern14);
            }
        }

        private void ButtonMSIGF76Star_PKR_Click(object sender, EventArgs e)
        {
            if (pictureBoxMSIGF761Star_PKR.Visible == true && pictureBoxMSIGF762Star_PKR.Visible == false)
            {
                pictureBoxMSIGF761Star_PKR.Visible = false;
                pictureBoxMSIGF762Star_PKR.Visible = true;
            }
            else
            {
                pictureBoxMSIGF761Star_PKR.Visible = true;
                pictureBoxMSIGF762Star_PKR.Visible = false;
            }

            // Получаем доступ к listBox в  форме Main
            ListBox listBox = mainForm.listBoxStar_PKR;
            string textMSIGF76 = ("MSI GF76 Katana Intel Core i5-11400H Цена: 75000");
            // Получаем выбранный текст из listBox
            if (listBox.Items.Contains(textMSIGF76))
            {
                listBox.Items.Remove(textMSIGF76);
            }
            else
            {
                listBox.Items.Add(textMSIGF76);
            }
            
        }

        private void ButtonMSIPreStar_PKR_Click(object sender, EventArgs e)
        {
            if (pictureBoxMSIPre1Star_PKR.Visible == true && pictureBoxMSIPre2Star_PKR.Visible == false)
            {
                pictureBoxMSIPre1Star_PKR.Visible = false;
                pictureBoxMSIPre2Star_PKR.Visible = true;
            }
            else
            {
                pictureBoxMSIPre1Star_PKR.Visible = true;
                pictureBoxMSIPre2Star_PKR.Visible = false;
            }

            // Получаем доступ к listBox в  форме Main
            ListBox listBox = mainForm.listBoxStar_PKR;
            string textMSIPre = ("MSI Prestige 14 A12SC-246RU Intel Core i5-1240P Цена: 97400");
            // Получаем выбранный текст из listBox
            if (listBox.Items.Contains(textMSIPre))
            {
                listBox.Items.Remove(textMSIPre);
            }
            else
            {
                listBox.Items.Add(textMSIPre);
            }
        }

        private void ButtonMSIGF63Star_PKR_Click(object sender, EventArgs e)
        {
            if (pictureBoxMSIGF631Star_PKR.Visible == true && pictureBoxMSIGF632Star_PKR.Visible == false)
            {
                pictureBoxMSIGF631Star_PKR.Visible = false;
                pictureBoxMSIGF632Star_PKR.Visible = true;
            }
            else
            {
                pictureBoxMSIGF631Star_PKR.Visible = true;
                pictureBoxMSIGF632Star_PKR.Visible = false;
            }

            // Получаем доступ к listBox в  форме Main
            ListBox listBox = mainForm.listBoxStar_PKR;
            string textMSIGF63 = ("MSI GF63 Thin 11SC-294XKZ ntel Core i5-11400H Цена: 99800");
            // Получаем выбранный текст из listBox
            if (listBox.Items.Contains(textMSIGF63))
            {
                listBox.Items.Remove(textMSIGF63);
            }
            else
            {
                listBox.Items.Add(textMSIGF63);
            }
            
        }

        private void FormMSI_Load(object sender, EventArgs e)
        {
            ListBox listBox = mainForm.listBoxStar_PKR;
            string textMSIGF66 = ("MSI GF66 Katana 11UE-408XRU Intel Core i5-11400H Цена: 107000");
            // Получаем выбранный текст из listBox
            if (listBox.Items.Contains(textMSIGF66))
            {
                pictureBoxMSIGF661Star_PKR.Visible = false;
                pictureBoxMSIGF662Star_PKR.Visible = true;
            }
            else
            {
                pictureBoxMSIGF661Star_PKR.Visible = true;
                pictureBoxMSIGF662Star_PKR.Visible = false;
            }

            string textMSIModern14 = ("MSI Modern 14 C12M-233XRU Intel Core i3-1215U Цена: 38000");
            // Получаем выбранный текст из listBox
            if (listBox.Items.Contains(textMSIModern14))
            {
                pictureBoxMSIModern141Star_PKR.Visible = false;
                pictureBoxMSIModern142Star_PKR.Visible = true;
            }
            else
            {
                pictureBoxMSIModern141Star_PKR.Visible = true;
                pictureBoxMSIModern142Star_PKR.Visible = false;
            }

            string textMSIGF76 = ("MSI GF76 Katana Intel Core i5-11400H Цена: 75000");
            // Получаем выбранный текст из listBox
            if (listBox.Items.Contains(textMSIGF76))
            {
                pictureBoxMSIGF761Star_PKR.Visible = false;
                pictureBoxMSIGF762Star_PKR.Visible = true;
            }
            else
            {
                pictureBoxMSIGF761Star_PKR.Visible = true;
                pictureBoxMSIGF762Star_PKR.Visible = false;
            }

            string textMSIPre = ("MSI Prestige 14 A12SC-246RU Intel Core i5-1240P Цена: 97400");
            // Получаем выбранный текст из listBox
            if (listBox.Items.Contains(textMSIPre))
            {
                pictureBoxMSIPre1Star_PKR.Visible = false;
                pictureBoxMSIPre2Star_PKR.Visible = true;
            }
            else
            {
                pictureBoxMSIPre1Star_PKR.Visible = true;
                pictureBoxMSIPre2Star_PKR.Visible = false;
            }

            string textMSIGF63 = ("MSI GF63 Thin 11SC-294XKZ ntel Core i5-11400H Цена: 99800");
            // Получаем выбранный текст из listBox
            if (listBox.Items.Contains(textMSIGF63))
            {
                pictureBoxMSIGF631Star_PKR.Visible = false;
                pictureBoxMSIGF632Star_PKR.Visible = true;
            }
            else
            {
                pictureBoxMSIGF631Star_PKR.Visible = true;
                pictureBoxMSIGF632Star_PKR.Visible = false;
            }

        }
    }
}
