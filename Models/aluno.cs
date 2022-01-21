using System;
using exemploPOO.Models;

namespace exemploPOO.Models
{
    public class Aluno : Pessoa
    {
        public int nota { get; set; }

        public override void apresentar()
        {
            Console.WriteLine($" Aluno: Olá meu nome é {this.nome} e tenho {this.idade} anos ");
        }
    }
}