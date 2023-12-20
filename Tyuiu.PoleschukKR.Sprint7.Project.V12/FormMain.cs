using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.PoleschukKR.Sprint7.Project.V12.Lib;

namespace Tyuiu.PoleschukKR.Sprint7.Project.V12
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

       private void CustomizeDesing()
        {
            panelSearchMenu_PKR.Visible = false;
        }

        private void HideSearchMenu()
        {
            if (panelSearchMenu_PKR.Visible == true)
                panelSearchMenu_PKR.Visible = false;
        }

        private void ShowSearchMenu(Panel searchMenu)
        {
            if (searchMenu.Visible == false)
            {
                HideSearchMenu();
                searchMenu.Visible = true;
            }
            else
            {
                searchMenu.Visible = false;
            }
        }

        private void ButtonInfo_PKR_Click(object sender, EventArgs e)
        {
            FormAbout formaAbout = new FormAbout();
            formaAbout.ShowDialog();
        }

        private void ButtonSearch_PKR_Click(object sender, EventArgs e)
        {
            ShowSearchMenu(panelSearchMenu_PKR);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //
            //
            HideSearchMenu();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            //
            //
            HideSearchMenu();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            //
            //
            HideSearchMenu();
        }

        private Form activeForm = null;
        private void OpenTableCompForm(Form tableComp)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = tableComp;
            tableComp.TopLevel = false;
            tableComp.FormBorderStyle = FormBorderStyle.None;
            tableComp.Dock = DockStyle.Fill;
            panelMain_PKR.Controls.Add(tableComp);
            panelMain_PKR.Tag = tableComp;
            tableComp.BringToFront();
            tableComp.Show();


            
        }

        private void buttonCompanies_PKR_Click(object sender, EventArgs e)
        {
            FormAboutCompanies formaAboutCompanies = new FormAboutCompanies();
            formaAboutCompanies.ShowDialog();
        }
    }
}
