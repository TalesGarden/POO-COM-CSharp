using System;
using exemploPOO.Models;

namespace exemploPOO.Models
{
    public class Diretor : Professor
    {
        public override void apresentar()
        {
            Console.WriteLine($" Diretor:  Olá meu nome é {this.nome} e tenho R$ {this.idade} ");
        }


}
}