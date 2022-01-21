using System;
using exemploPOO.Models;
using exemploPOO.Helper;
using System.IO;
using System.Collections.Generic;

namespace exemploPOO
{
  public class Program
  {
    static void Main(string[] args)
    {
 
      //Manipulando Arquivos

      var path = "C:\\OOP\\";
      var newPath = "C:\\POO";
      FileHelper file = new FileHelper();

      var caminhoArquivo = Path.Combine(path, "Novo-Arquivo-Principal.txt");
      var caminhoArquivoStream = Path.Combine(path, "Arquivo-Criado-com Stream.txt");
      var novoCaminhoArquivo = Path.Combine(newPath, "Arquivo teste move", "Arquivo-teste-move.txt");
      file.ListarDiretorios(path);

      file.listaArquivosDiretorios(path);

      file.CriarDiretorio(Path.Combine(path, "Pasta p3", "SubPasta p3"));

      //bool apagarArquivo = true;
     // file.ApagarDiretorio(path, apagarArquivo);

      file.CriarArquivoTexto(caminhoArquivo, "Arquivo texto FILE");

      var listString = new List<string>() { "bird", "dog" };

      file.CriarArquivoTextoStream(caminhoArquivoStream, listString );

      file.AdicionarTexto(caminhoArquivo, "Ola Mundo ");

      file.AdicionarTextoStream(caminhoArquivoStream, listString );

      file.LerArquivoStream(caminhoArquivoStream);
      file.MoverArquivo(caminhoArquivo, novoCaminhoArquivo);

      file.CopiarArquivo(caminhoArquivo, novoCaminhoArquivo, false);
      file.DeletarArquivo(caminhoArquivo);

    //   Calculadora calculadora = new Calculadora();

    //   //lançando um Exceptions, divisão por 0
    //   calculadora.Dividir(1,0);
    //   calculadora.Somar(-5,0);
    //   calculadora.Subtrair(4,-5);


    //   Aluno primeiroAluno =  new Aluno();
    //   primeiroAluno.nome = "tales";
    //   primeiroAluno.idade = 27;
    //   primeiroAluno.nota = 100;
    //   primeiroAluno.apresentar();

    //   ContaCorrente MinhaConta = new ContaCorrente();

    //   MinhaConta.Creditar(1500);

    //   MinhaConta.exibirSaldo();
    
    //   Professor prof = new Professor();
    //   prof.salario = 20000;

    //  // Pessoa pessoa = new Pessoa();  não funciona, classe pessoa é abstrata

    //   Diretor diretor  = new Diretor();
    //   diretor.nome = "joao";
    //   diretor.salario = 5000;


    //   //polimorfismo

    //   apresentarPessoa( primeiroAluno );
    //   apresentarPessoa( diretor );

      
      // Pessoa pessoa = new Pessoa();
      // Console.WriteLine("\t-----------------\t");
      // pessoa.nome = "tales";
      // pessoa.idade = 27;
      // Console.WriteLine("\t-----------------\t");

      // Console.WriteLine("Hello, World! : "+ pessoa.ToString());

      //  Retangulo elemento = new Retangulo();

      //  Console.WriteLine("\t-----------------\t");
      //  elemento.DefineMedidas(10,5);
      //  elemento.exibeArea();
      //  double area = elemento.ObterArea();
      //  Console.WriteLine("\t-----------------\t");

      //  Console.WriteLine($"Area de retangulo: {area}");

     
 
   }

//isso se chama polimorfirmos
   public static void apresentarPessoa(Pessoa pessoa)
   {
     pessoa.apresentar();
   }
  }


}