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
    public partial class FormASUS : Form
    {
        // Получаем текущий экземпляр формы MainForm
        FormMain mainForm = (FormMain)Application.OpenForms["FormMain"];
        public FormASUS()
        {
            InitializeComponent();
        }

        private void ButtonAsusRogChangePicture_PKR_Click(object sender, EventArgs e)
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

        private void ButtonAsusZenPictureChange_PKR_Click(object sender, EventArgs e)
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

        private void ButtonAsusVivo17ChangePicture_PKR_Click(object sender, EventArgs e)
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

        private void TextBoxAsusRog_PKR_Enter(object sender, EventArgs e)
        {
            (sender as TextBox).SelectionStart = 0;
        }

        private void ButtonAsusVivo15PictureChange_PKR_Click(object sender, EventArgs e)
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

        private void ButtonAsusVivo16PictureChange_PKR_Click(object sender, EventArgs e)
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

        private void LinkLabelAsusZen_PKR_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo { FileName = "https://youtu.be/ZBFyWUynNrs?si=ke3HPgIoG0xw1KJa", UseShellExecute = true });

        }

        private void LinkLabelAsusRog_PKR_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo { FileName = "https://youtu.be/1T7IL80Z750?si=Umh0e2jsWgVN92z-", UseShellExecute = true });

        }

        private void LinkLabelAsusVivo17_PKR_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo { FileName = "https://youtu.be/vQvYhuc1fA4?si=Vmw5IdqfIUZb0erd", UseShellExecute = true });

        }

        private void LinkLabelAsusVivo15_PKR_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo { FileName = "https://youtu.be/uahQ8XpiWik?si=DETJuF0O2Vj9ZjQS", UseShellExecute = true });
        
        }

        private void LinkLabelAsusVivo16_PKR_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo { FileName = "https://youtu.be/16b5K-sHdcI?si=oAAX5pAQf6hVYogL", UseShellExecute = true });

        }

        private void ButtonAsusRogStar_PKR_Click(object sender, EventArgs e)
        {
            if (pictureBoxAsusRog1Star_PKR.Visible == true && pictureBoxAsusRog2Star_PKR.Visible == false)
            {
                pictureBoxAsusRog1Star_PKR.Visible = false;
                pictureBoxAsusRog2Star_PKR.Visible = true;
            }
            else
            {
                pictureBoxAsusRog1Star_PKR.Visible = true;
                pictureBoxAsusRog2Star_PKR.Visible = false;
            }
            // Получаем доступ к listBox в  форме Main
            ListBox listBox = mainForm.listBoxStar_PKR;
            string textAsusRog = ("ASUS ROG Strix G513IE_G513IE AMD Ryzen 7 4800H Цена: 115000");
            // Получаем выбранный текст из listBox
            if (listBox.Items.Contains(textAsusRog))
            {
                listBox.Items.Remove(textAsusRog);
            }
            else
            {
                listBox.Items.Add(textAsusRog);
            }
        }

        private void ButtonAsusZenStar_PKR_Click(object sender, EventArgs e)
        {
            if (pictureBoxAsusZen1Star_PKR.Visible == true && pictureBoxAsusZen2Star_PKR.Visible == false)
            {
                pictureBoxAsusZen1Star_PKR.Visible = false;
                pictureBoxAsusZen2Star_PKR.Visible = true;
            }
            else
            {
                pictureBoxAsusZen1Star_PKR.Visible = true;
                pictureBoxAsusZen2Star_PKR.Visible = false;
            }
            // Получаем доступ к listBox в  форме Main
            ListBox listBox = mainForm.listBoxStar_PKR;
            string textAsusZen = ("ASUS ZenBook 14X OLED Intel Core i7 13700H  Цена: 149000");
            // Получаем выбранный текст из listBox
            if (listBox.Items.Contains(textAsusZen))
            {
                listBox.Items.Remove(textAsusZen);
            }
            else
            {
                listBox.Items.Add(textAsusZen);
            }
        }

        private void ButtonAsusVivo17Star_PKR_Click(object sender, EventArgs e)
        {
            if (pictureBoxAsusVivo171Star_PKR.Visible == true && pictureBoxAsusVivo172Star_PKR.Visible == false)
            {
                pictureBoxAsusVivo171Star_PKR.Visible = false;
                pictureBoxAsusVivo172Star_PKR.Visible = true;
            }
            else
            {
                pictureBoxAsusVivo171Star_PKR.Visible = true;
                pictureBoxAsusVivo172Star_PKR.Visible = false;
            }
            // Получаем доступ к listBox в  форме Main
            ListBox listBox = mainForm.listBoxStar_PKR;
            string textAsusVivo17 = ("ASUS Vivobook X1704ZA-AU123 Intel Core i5-1235U Цена: 59000");
            // Получаем выбранный текст из listBox
            if (listBox.Items.Contains(textAsusVivo17))
            {
                listBox.Items.Remove(textAsusVivo17);
            }
            else
            {
                listBox.Items.Add(textAsusVivo17);
            }
        }

        private void ButtonAsusvivo15Star_PKR_Click(object sender, EventArgs e)
        {
            if (pictureBoxAsusVivo151Star_PKR.Visible == true && pictureBoxAsusVivo152Star_PKR.Visible == false)
            {
                pictureBoxAsusVivo151Star_PKR.Visible = false;
                pictureBoxAsusVivo152Star_PKR.Visible = true;
            }
            else
            {
                pictureBoxAsusVivo151Star_PKR.Visible = true;
                pictureBoxAsusVivo152Star_PKR.Visible = false;
            }

            // Получаем доступ к listBox в  форме Main
            ListBox listBox = mainForm.listBoxStar_PKR;
            string textAsusVivo15 = ("ASUS Vivobook Go 15 AMD Ryzen 5 7520U  Цена: 48600");
            // Получаем выбранный текст из listBox
            if (listBox.Items.Contains(textAsusVivo15))
            {
                listBox.Items.Remove(textAsusVivo15);
            }
            else
            {
                listBox.Items.Add(textAsusVivo15);
            }
        }

        private void ButtonAsusVivo16Star_PKR_Click(object sender, EventArgs e)
        {
            if (pictureBoxAsusVivo161Star_PKR.Visible == true && pictureBoxAsusVivo162Star_PKR.Visible == false)
            {
                pictureBoxAsusVivo161Star_PKR.Visible = false;
                pictureBoxAsusVivo162Star_PKR.Visible = true;
            }
            else
            {
                pictureBoxAsusVivo161Star_PKR.Visible = true;
                pictureBoxAsusVivo162Star_PKR.Visible = false;
            }
            // Получаем доступ к listBox в  форме Main
            ListBox listBox = mainForm.listBoxStar_PKR;
            string textAsusVivo16 = ("ASUS VivoBook 16 X1605ZA-MB018W Intel Core i3-1215U Цена: 49600");
            // Получаем выбранный текст из listBox
            if (listBox.Items.Contains(textAsusVivo16))
            {
                listBox.Items.Remove(textAsusVivo16);
            }
            else
            {
                listBox.Items.Add(textAsusVivo16);
            }
        }

        private void FormASUS_Load(object sender, EventArgs e)
        {
            ListBox listBox = mainForm.listBoxStar_PKR;
            string textAsusRog = ("ASUS ROG Strix G513IE_G513IE AMD Ryzen 7 4800H Цена: 115000");
            // Получаем выбранный текст из listBox
            if (listBox.Items.Contains(textAsusRog))
            {
                pictureBoxAsusRog1Star_PKR.Visible = false;
                pictureBoxAsusRog2Star_PKR.Visible = true;
            }
            else
            {
                pictureBoxAsusRog1Star_PKR.Visible = true;
                pictureBoxAsusRog2Star_PKR.Visible = false;
            }

            string textAsusZen = ("ASUS ZenBook 14X OLED Intel Core i7 13700H  Цена: 149000");
            // Получаем выбранный текст из listBox
            if (listBox.Items.Contains(textAsusZen))
            {
                pictureBoxAsusZen1Star_PKR.Visible = false;
                pictureBoxAsusZen2Star_PKR.Visible = true;
            }
            else
            {
                pictureBoxAsusZen1Star_PKR.Visible = true;
                pictureBoxAsusZen2Star_PKR.Visible = false;
            }

            string textAsusVivo17 = ("ASUS Vivobook X1704ZA-AU123 Intel Core i5-1235U Цена: 59000");
            // Получаем выбранный текст из listBox
            if (listBox.Items.Contains(textAsusVivo17))
            {
                pictureBoxAsusVivo171Star_PKR.Visible = false;
                pictureBoxAsusVivo172Star_PKR.Visible = true;
            }
            else
            {
                pictureBoxAsusVivo171Star_PKR.Visible = true;
                pictureBoxAsusVivo172Star_PKR.Visible = false;
            }

            string textAsusVivo15 = ("ASUS Vivobook Go 15 AMD Ryzen 5 7520U  Цена: 48600");
            // Получаем выбранный текст из listBox
            if (listBox.Items.Contains(textAsusVivo15))
            {
                pictureBoxAsusVivo151Star_PKR.Visible = false;
                pictureBoxAsusVivo152Star_PKR.Visible = true;
            }
            else
            {
                pictureBoxAsusVivo151Star_PKR.Visible = true;
                pictureBoxAsusVivo152Star_PKR.Visible = false;
            }

            string textAsusVivo16 = ("ASUS VivoBook 16 X1605ZA-MB018W Intel Core i3-1215U Цена: 49600");
            // Получаем выбранный текст из listBox
            if (listBox.Items.Contains(textAsusVivo16))
            {
                pictureBoxAsusVivo161Star_PKR.Visible = false;
                pictureBoxAsusVivo162Star_PKR.Visible = true;
            }
            else
            {
                pictureBoxAsusVivo161Star_PKR.Visible = true;
                pictureBoxAsusVivo162Star_PKR.Visible = false;
            }
        }
    }
}
