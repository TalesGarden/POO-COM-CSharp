namespace exemploPOO.Models
{
    // if class sealed , no more subclass of their type
    public  class  Professor: Pessoa
    {
        public double salario { get; set; }
         public override void apresentar()
        {
            Console.WriteLine($" Professor:  Olá meu nome é {this.nome} e tenho R$ {this.idade} ");
        }
    }
}