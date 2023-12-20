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
        public void ValidCollectTextFromFileAsus()
        {
            DataService ds = new DataService();
            string path = @"C:\Users\ILYA\source\repos\Tyuiu.PoleschukKR.Sprint7\Tyuiu.PoleschukKR.Sprint7.Project.V12\bin\Debug\Компания Asus.txt";
            string[] res = ds.CollectTextFromFileAsus(path);
            string[] wait = { "Наименование: Asus", "Адрес: 15 Li-Te Road, Peitou, Taipei, 11259, Taiwan", "Телефон: +886-2-2894-3447"};
            CollectionAssert.AreEqual(wait, res);

        }

        [TestMethod]    
        public void ValidCollectTextFromFileMSI()
        {
            DataService ds = new DataService();
            string path = @"C:\Users\ILYA\source\repos\Tyuiu.PoleschukKR.Sprint7\Tyuiu.PoleschukKR.Sprint7.Project.V12\bin\Debug\Компания MSI.txt";
            string[] res = ds.CollectTextFromFileAsus(path);
            string[] wait = { "Наименование: MSI (Micro-Star International Co., Ltd.)", "Адрес: No. 69, Lide St., Zhonghe Dist., New Taipei City 235, Taiwan", "Телефон: +886-2-3234-3355"};
            CollectionAssert.AreEqual(wait, res);

        }

    }
}
