using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.PoleschukKR.Sprint7.Project.V12.Lib;

namespace Tyuiu.PoleschukKR.Sprint7.Project.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {

        [TestMethod]
        public void ValidCollectTextFromFileMSI()
        {
            DataService ds = new DataService();
            string path = @"C:\Users\ILYA\source\repos\Tyuiu.PoleschukKR.Sprint7\Tyuiu.PoleschukKR.Sprint7.Project.V12\bin\Debug\Files\Тест.MSI.csv";
            string[] res = ds.CollectTextFromFileMSI(path);
            string[] wait = { "Сведения о компании:", "Наименование: MSI (Micro-Star International Co., Ltd.)", "", "Адрес: No. 69, Lide St., Zhonghe Dist., New Taipei City 235, Taiwan", "", "Телефон: +886-2-3234-3355" };
            CollectionAssert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidGetData()
        {
            DataService ds = new DataService();

            string path = @"C:\Users\ILYA\source\repos\Tyuiu.PoleschukKR.Sprint7\Tyuiu.PoleschukKR.Sprint7.Project.V12\bin\Debug\Files\ЭВМ Тест.csv";
            string[,] res = ds.GetData(path);

            string[,] wait = {
                { "MSI", "AMD Ryzen 5 3600", "8", "3,5", "16", "1000", "2020", "40000" },
                { "ASUS", "AMD Ryzen 7 1600", "6", "3,7", "16", "1000", "2015", "35000" }
            };

            CollectionAssert.AreEqual(wait, res);

        }
    }
}
