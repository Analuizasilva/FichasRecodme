using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Ficha20
{
    public class Ficha20Solucao
    {
        #region Exercicio
        public static void Exercicio()
        {
            //Exercicio 1
            DirectoryInfo folder = new DirectoryInfo(@"C:\Users\Ana Silva\Desktop");
            folder.CreateSubdirectory("AnaLuizaSilva");

            //Exercicio 3
            StreamWriter x;
            string aFile = ("C:\\Users\\Ana Silva\\Desktop\\AnaLuizaSilva\\arq01.txt");
            x = File.CreateText(aFile);

            //Exercicio 4
            x.WriteLine("Help me!");
            x.Close();

            //Exercicio 5
            StreamReader reader;
            reader = File.OpenText(aFile);

            while (reader.EndOfStream != true)
            {
                string linha = reader.ReadLine();
                Console.WriteLine(linha);
            }
            reader.Close();
            //Exercicio 6
            string extensao = Path.GetExtension(aFile);
            Console.WriteLine($"A extensão do arquivo é: {extensao}");

            //Exercicio 7
            string path = Path.GetDirectoryName(aFile);
            Console.WriteLine(path);

            //Exercicio 8
            string name = Path.GetFileName(aFile);
            Console.WriteLine(name);

            //Exercicio 9
            File.Delete(aFile);

            //Exercicio 10            
            Directory.Delete(@"C:\Users\Ana Silva\Desktop\AnaLuizaSilva");            
        }
        #endregion        
    }
}
