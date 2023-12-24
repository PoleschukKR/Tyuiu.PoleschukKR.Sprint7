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
        
        public string[] CollectTextFromFileMSI(string path)
        {
            string[] linesMSI = File.ReadAllLines(path);
            return linesMSI;
        }




        public string[,] GetData(string path)
        {
            string fileData = File.ReadAllText(path, Encoding.GetEncoding(1251));
            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            int rows = lines.Length;
            int columns = lines[0].Split(';').Length;

            string[,] arrayValues = new string[rows, columns];

            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(';');
                for (int c = 0; c < columns; c++)
                {
                    arrayValues[r, c] = line_r[c];
                }
            }
            return arrayValues;
        }

      
    }
}