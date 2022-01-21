using System.Collections.Generic;
using System.IO;
using System;

namespace exemploPOO.Helper
{
    public class FileHelper
    {
        public void ListarDiretorios(string path)
        {
            var result = Directory.GetDirectories(path, "*", SearchOption.AllDirectories);

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }

        public void listaArquivosDiretorios(string path)
        {
            //*.pdf apenas arquivos pdf
            var result =  Directory.GetFiles(path, "*.pdf", SearchOption.AllDirectories);

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }

        public void CriarDiretorio(string path)
        {
            var result =  Directory.CreateDirectory(path);

            Console.WriteLine(result.FullName);
        }

        public void ApagarDiretorio(string path, bool apagarArquivos = true)
        {
            Directory.Delete(path, apagarArquivos);
        }

        public void CriarArquivoTexto(string path, string conteudo)
        {
            if(!File.Exists(path) )
            {
                File.WriteAllText(path, conteudo);
            }            
        }

        public void CriarArquivoTextoStream(string path, List<string> conteudo )
        {
            //using garanto que o arquivo será fechado 
            var stream = File.CreateText(path);
            
                foreach (var line in conteudo)
                {
                    stream.WriteLine(line);
                }
            
        }
        public void AdicionarTexto(string path, string conteudo)
        {
            File.AppendAllText(path, conteudo);
        }

        
        public void AdicionarTextoStream(string path, List<string> conteudo)
        {
            var stream = File.AppendText(path);
            
                foreach (var line in conteudo)
                {
                    stream.WriteLine(line);
                }
            
        }

        public void LerArquivo(string path)
        {
            var conteudoArquivo = File.ReadAllLines(path);
            
            foreach (var linha in conteudoArquivo)
            {
                Console.WriteLine();
            }
        }

        public void LerArquivoStream(string path)
        {
            string  linha = string.Empty;

            var stream =  File.OpenText(path);

            while((linha = stream.ReadLine()) != null)
            {
                Console.WriteLine(linha);
            }
            
        }

        public void MoverArquivo(string path, string newPath)
        {
            File.Move(path, newPath);
 
        }

        public void CopiarArquivo(string path, string newPath, bool sobrescrever )
        {
            File.Copy(path, newPath,sobrescrever );
        }
        
        public void DeletarArquivo(string path)
        {
            File.Delete(path);
        }
        
        
    }
}