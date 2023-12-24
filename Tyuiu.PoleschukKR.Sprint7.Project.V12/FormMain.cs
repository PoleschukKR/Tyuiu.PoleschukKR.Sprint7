using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            openFileDialogStar_PKR.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Всефайлы(*.*)|*.*";
            saveFileDialogStar_PKR.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Всефайлы(*.*)|*.*";
        }
        DataService ds = new DataService();
        string pathPcBase = @"C:\Users\ILYA\source\repos\Tyuiu.PoleschukKR.Sprint7\Tyuiu.PoleschukKR.Sprint7.Project.V12\bin\Debug\Files\База ЭВМ.csv";

        public static ListBox ListBoxControl { get; internal set; }

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

        private void ButtonCompanies_PKR_Click(object sender, EventArgs e)
        {
            FormAboutCompanies formaAboutCompanies = new FormAboutCompanies();
            formaAboutCompanies.ShowDialog();
        }

        private void ButtonHelp_PKR_Click(object sender, EventArgs e)
        {
            FormGuidForUser formGuidForUser = new FormGuidForUser();
            formGuidForUser.ShowDialog();
        }

        
        

        private void ButtonAsusMenu_PKR_Click(object sender, EventArgs e)
        {
            FormASUS formASUS = new FormASUS();
            formASUS.ShowDialog();
            HideSearchMenu();
        }

        private void ButtonMSIMenu_PKR_Click(object sender, EventArgs e)
        {
            FormMSI formMSI = new FormMSI();
            formMSI.ShowDialog();
            HideSearchMenu();
        }

        private void ButtonHPMenu_PKR_Click(object sender, EventArgs e)
        {
            FormHP formHP = new FormHP();
            formHP.ShowDialog();
            HideSearchMenu();
        }

        private void ButtonHuaweiMenu_PKR_Click(object sender, EventArgs e)
        {
            FormHuawei formHuawei = new FormHuawei();
            formHuawei.ShowDialog();
            HideSearchMenu();
        }

        private void ButtonEVMBase_PKR_Click(object sender, EventArgs e)
        {
           

            panelMainBase_PKR.Visible = true;
            panelMainMenu_PKR.Visible = false;
            try
            {

                string[,] DataMatrix = ds.GetData(pathPcBase);

                int rows = DataMatrix.GetLength(0);
                int columns = DataMatrix.GetLength(1);

                dataGridViewEVMBase_PKR.RowCount = rows ;
                dataGridViewEVMBase_PKR.ColumnCount = columns;

                dataGridViewEVMBase_PKR.Columns[0].HeaderText = "Модель";
                dataGridViewEVMBase_PKR.Columns[0].Width = 420;

                dataGridViewEVMBase_PKR.Columns[1].HeaderText = "Год релиза";
                dataGridViewEVMBase_PKR.Columns[1].Width = 80;

                dataGridViewEVMBase_PKR.Columns[2].HeaderText = "Процессор";
                dataGridViewEVMBase_PKR.Columns[2].Width = 250;


                dataGridViewEVMBase_PKR.Columns[3].HeaderText = "Видеокарта";
                dataGridViewEVMBase_PKR.Columns[3].Width = 250;

                dataGridViewEVMBase_PKR.Columns[4].HeaderText = "Цена";
                dataGridViewEVMBase_PKR.Columns[4].Width = 80;


                for (int r = 0; r < rows; r++)
                {
                    for (int c = 0; c < columns; c++)
                    {
                        dataGridViewEVMBase_PKR.Rows[r].Cells[c].Value = DataMatrix[r, c];
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonReturnMainMenu_PKR_Click(object sender, EventArgs e)
        {
            panelMainMenu_PKR.Visible = true;
        }

        private void ButtonOpenFileStar_PKR_Click(object sender, EventArgs e)
        {
            openFileDialogStar_PKR.FileName = "Сохраненная корзина";

            try
            {

                // Позволяет пользователю выбрать файл для открытия
                if (openFileDialogStar_PKR.ShowDialog() == DialogResult.OK)
                {
                    // Читаем строки из выбранного файла и добавляем их в ListBox
                    string[] lines = File.ReadAllLines(openFileDialogStar_PKR.FileName);
                    foreach (string line in lines)
                    {
                        listBoxStar_PKR.Items.Add(line);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Файл не выбран!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonSaveFileStar_PKR_Click(object sender, EventArgs e)
        {
            try
            {
                saveFileDialogStar_PKR.FileName = "Сохраненная корзина.csv";
                saveFileDialogStar_PKR.InitialDirectory = Directory.GetCurrentDirectory();
                saveFileDialogStar_PKR.ShowDialog();
                

                if (saveFileDialogStar_PKR.FileName != "")
                {
                    using (StreamWriter sw = new StreamWriter(saveFileDialogStar_PKR.FileName))
                    {
                        foreach (var item in listBoxStar_PKR.Items)
                        {
                            sw.WriteLine(item.ToString());
                        }
                    }
                }
                
            }
            catch
            {

                MessageBox.Show("Файл не сохранен!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void ButtonProducts_PKR_Click(object sender, EventArgs e)
        {
            panelStar_PKR.Visible = true;
            buttonEVMBase_PKR.Visible = false;

        }

        private void ButtonReturnMenuFromStar_PKR_Click(object sender, EventArgs e)
        {
            panelStar_PKR.Visible = false;
            buttonEVMBase_PKR.Visible = true;


        }

        private void ButtonClearListStar_PKR_Click(object sender, EventArgs e)
        {
            listBoxStar_PKR.Items.Clear();
        }
    }
}
