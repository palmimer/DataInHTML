using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DataInHTML
{
    class FileReader
    {
        public String[] readCsvFileLines(string filePath)
        {
            string[] lines = new string[] {};
            lines = File.ReadAllLines(filePath);
            return lines;
        }

        public string[] getDataFromLine(string line)
        {
            string[] data = line.Split(",");
            for(int i = 0; i < data.Length; i++)
            {
                data[i] = data[i].Trim();
            }
            return data;
        }

    }
}
