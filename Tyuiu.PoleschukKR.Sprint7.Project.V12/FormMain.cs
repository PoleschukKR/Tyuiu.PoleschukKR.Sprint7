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
        DataService ds = new DataService();
        string pathPcBase = @"C:\Users\ILYA\Desktop\Проект ЭВМ.csv";

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


        private void buttonCompanies_PKR_Click(object sender, EventArgs e)
        {
            FormAboutCompanies formaAboutCompanies = new FormAboutCompanies();
            formaAboutCompanies.ShowDialog();
        }

        private void buttonHelp_PKR_Click(object sender, EventArgs e)
        {
            FormGuidForUser formGuidForUser = new FormGuidForUser();
            formGuidForUser.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {

                string[,] DataMatrix = ds.GetData(pathPcBase);

                int rows = DataMatrix.GetLength(0);
                int columns = DataMatrix.GetLength(1);

                dataGridView1.RowCount = rows + 1;
                dataGridView1.ColumnCount = columns;

                dataGridView1.Columns[0].HeaderText = "Модель";
                dataGridView1.Columns[0].Width = 350;

                dataGridView1.Columns[1].HeaderText = "Год релиза";
                dataGridView1.Columns[1].Width = 80;

                dataGridView1.Columns[2].HeaderText = "Процессор";
                dataGridView1.Columns[2].Width = 200;

                dataGridView1.Columns[3].HeaderText = "Количество ядер";
                dataGridView1.Columns[3].Width = 120;

                dataGridView1.Columns[4].HeaderText = "Тактовая частота(ГГц)";
                dataGridView1.Columns[4].Width = 150;

                dataGridView1.Columns[5].HeaderText = "Объем ОП";
                dataGridView1.Columns[5].Width = 80;

                dataGridView1.Columns[6].HeaderText = "Видеокарта";
                dataGridView1.Columns[6].Width = 250;

                dataGridView1.Columns[7].HeaderText = "Диагональ экрана";
                dataGridView1.Columns[7].Width = 110;

                dataGridView1.Columns[8].HeaderText = "Частота обновления экрана";
                dataGridView1.Columns[8].Width = 250;

                dataGridView1.Columns[9].HeaderText = "Объем SSD";
                dataGridView1.Columns[9].Width = 100;

                dataGridView1.Columns[10].HeaderText = "Цена";
                dataGridView1.Columns[10].Width = 120;


                for (int r = 0; r < rows; r++)
                {
                    for (int c = 0; c < columns; c++)
                    {
                        dataGridView1.Rows[r].Cells[c].Value = DataMatrix[r, c];
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAsusMenu_PKR_Click(object sender, EventArgs e)
        {
            FormASUS formASUS = new FormASUS();
            formASUS.ShowDialog();
            HideSearchMenu();
        }
    }
}
