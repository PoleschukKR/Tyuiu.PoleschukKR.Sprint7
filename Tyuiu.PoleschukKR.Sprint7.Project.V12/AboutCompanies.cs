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

namespace Tyuiu.PoleschukKR.Sprint7.Project.V12
{
    public partial class FormAboutCompanies : Form
    {
        public FormAboutCompanies()
        {
            InitializeComponent();
        }

        private void buttonExitFormComp_PKR_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ComboBoxCompanies_PKR_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxCompanies_PKR.SelectedIndex == 0)
            {
                string pathAsus = @"C:\Users\ILYA\source\repos\Tyuiu.PoleschukKR.Sprint7\Tyuiu.PoleschukKR.Sprint7.Project.V12\bin\Debug\Компания Asus.txt";
                try
                {
                    using (StreamReader reader = new StreamReader(pathAsus))
                    {
                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            listBoxCompanies_PKR.Items.Add(line); // Добавление каждой строки из файла в ListBox
                        }
                    }
                }
                catch (FileNotFoundException)
                {
                    MessageBox.Show("Файл не найден");
                }
            }
            
            if (ComboBoxCompanies_PKR.SelectedIndex == 1)
            {
                string pathMSI = @"C:\Users\ILYA\source\repos\Tyuiu.PoleschukKR.Sprint7\Tyuiu.PoleschukKR.Sprint7.Project.V12\bin\Debug\Компания MSI.txt";
                try
                {
                    using (StreamReader reader = new StreamReader(pathMSI))
                    {
                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            listBoxCompanies_PKR.Items.Add(line); // Добавление каждой строки из файла в ListBox
                        }
                    }
                }
                catch (FileNotFoundException)
                {
                    MessageBox.Show("Файл не найден");
                }
            }

            if (ComboBoxCompanies_PKR.SelectedIndex == 2)
            {
                string pathHP = @"C:\Users\ILYA\source\repos\Tyuiu.PoleschukKR.Sprint7\Tyuiu.PoleschukKR.Sprint7.Project.V12\bin\Debug\Компания HP.txt";
                try
                {
                    using (StreamReader reader = new StreamReader(pathHP))
                    {
                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            listBoxCompanies_PKR.Items.Add(line); // Добавление каждой строки из файла в ListBox
                        }
                    }
                }
                catch (FileNotFoundException)
                {
                    MessageBox.Show("Файл не найден");
                }
            }

            if (ComboBoxCompanies_PKR.SelectedIndex == 3)
            {
                string pathHuawei = @"C:\Users\ILYA\source\repos\Tyuiu.PoleschukKR.Sprint7\Tyuiu.PoleschukKR.Sprint7.Project.V12\bin\Debug\Компания Huawei.txt";
                try
                {
                    using (StreamReader reader = new StreamReader(pathHuawei))
                    {
                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            listBoxCompanies_PKR.Items.Add(line); // Добавление каждой строки из файла в ListBox
                        }
                    }
                }
                catch (FileNotFoundException)
                {
                    MessageBox.Show("Файл не найден");
                }
            }


            if (ComboBoxCompanies_PKR.SelectedIndex == 4)
            {
                string pathIntel = @"C:\Users\ILYA\source\repos\Tyuiu.PoleschukKR.Sprint7\Tyuiu.PoleschukKR.Sprint7.Project.V12\bin\Debug\Компания Intel.txt";
                try
                {
                    using (StreamReader reader = new StreamReader(pathIntel))
                    {
                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            listBoxCompanies_PKR.Items.Add(line); // Добавление каждой строки из файла в ListBox
                        }
                    }
                }
                catch (FileNotFoundException)
                {
                    MessageBox.Show("Файл не найден");
                }
            }

            if (ComboBoxCompanies_PKR.SelectedIndex == 5)
            {
                string pathAMD = @"C:\Users\ILYA\source\repos\Tyuiu.PoleschukKR.Sprint7\Tyuiu.PoleschukKR.Sprint7.Project.V12\bin\Debug\Компания AMD.txt";
                try
                {
                    using (StreamReader reader = new StreamReader(pathAMD))
                    {
                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            listBoxCompanies_PKR.Items.Add(line); // Добавление каждой строки из файла в ListBox
                        }
                    }
                }
                catch (FileNotFoundException)
                {
                    MessageBox.Show("Файл не найден");
                }
            }
        }

        private void roundButtonInfoAboutCompanies_Click(object sender, EventArgs e)
        {
            listBoxCompanies_PKR.Items.Clear(); // Очистка всех элементов в ListBox
        }

        private void buttonExitFormComp_PKR_MouseDown(object sender, MouseEventArgs e)
        {
            buttonExitFormComp_PKR.BackColor = Color.Red;
        }

        private void buttonExitFormComp_PKR_MouseLeave(object sender, EventArgs e)
        {
            buttonExitFormComp_PKR.BackColor = Color.FromArgb(52,52,52);

        }
    }
}   
