using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.PoleschukKR.Sprint7.Project.V12.Lib;

namespace Tyuiu.PoleschukKR.Sprint7.Project.V12.Lib
{
    public class DataService
    {
        public string[] CollectTextFromFileAsus(string path)
        {
            string[] linesAsus = File.ReadAllLines(path);
            return linesAsus;
        }
        public string[] CollectTextFromFileMSI(string path)
        {
            string[] linesMSI = File.ReadAllLines(path);
            return linesMSI;
        }


    }
}