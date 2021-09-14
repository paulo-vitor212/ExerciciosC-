using System;
using System.IO;

namespace Aula03
{
    class Program
    {
        static void Main(string[] args)
        {
            string origemArquivoPath = @"..\..\..\..\Produtos.txt";
            string destinoArquivoPath = @"..\..\..\..\saida\nota.txt";
            string folderArquivoPath = @"..\..\..\..\saida";

            try
            {
                string[] lines = File.ReadAllLines(origemArquivoPath);

                if (!Directory.Exists(folderArquivoPath))
                {
                    Directory.CreateDirectory(folderArquivoPath);
                }

                if (File.Exists(destinoArquivoPath))
                {
                    File.WriteAllText(destinoArquivoPath, string.Empty);
                }

                using StreamWriter sw = File.AppendText(destinoArquivoPath);

                foreach (string line in lines)
                {
                    var arrayLine = line.Split(";");
                    string name = arrayLine[0];
                    double price = Convert.ToDouble(arrayLine[1]) * Convert.ToDouble(arrayLine[2]);

                    sw.WriteLine($"{name};{price:C2}");
                }

            }
            catch (IOException e)
            {
                Console.WriteLine("Erro: " + e.Message);
            }
        }
    }
}
