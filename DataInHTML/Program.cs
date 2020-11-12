using System;

namespace DataInHTML
{
    class Program
    {
        static void Main(string[] args)
        {
            FileReader fileReader = new FileReader();
            string[] allLines = fileReader.readCsvFileLines("C:/Users/dextra/Documents/DextraLineProjects/Adatmegjelenítés/CSV fájlok/cimek_teszt.csv");
            string[] separatedLine = fileReader.getDataFromLine(allLines[0]);
            Console.WriteLine("Hello Merci!");
            Console.WriteLine(allLines[0]);
            int i = 0;
            while (i < separatedLine.Length)
            {
                Console.WriteLine((i + 1) + ". " + separatedLine[i]);
                i++;
            }
            Console.WriteLine("Nyomj meg egy billentyűt a kilépéshez!");
            Console.ReadKey();
        }
    }
}
