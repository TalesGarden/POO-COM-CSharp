using System;

namespace exemploPOO.Models
{
    public class Pessoa
    {
        public string nome { get; set; }
        public  int idade { get; set; }

        public virtual void apresentar()
        {
            Console.WriteLine($" Olá meu nome é {this.nome} e tenho {this.idade} anos ");
        }

        //Polimofirsmo tempo de compilação - Overload / EARLY BIDING
        public void apresentar(string nome, string idade)
        {
            Console.WriteLine($" Olá meu nome é {nome} e tenho {idade} anos ");
        }

        public override string ToString()
        {
         return "Pessoa: " + this.nome + " " + this.idade;
        }
}
}