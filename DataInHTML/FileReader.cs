using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DataInHTML
{
    class FileReader
    {
        public List<string[]> readCsvFileLines(string filePath)
        {
            string[] lines = File.ReadAllLines(filePath);
            List<string[]> allLines = new List<string[]> { };
            for (int i = 0; i < lines.Length; i++)
            {

            }
            return allLines;
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
