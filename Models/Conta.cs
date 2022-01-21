namespace exemploPOO.Models
{
    public abstract class Conta
    {
        protected double saldo = 0;

        public abstract void Creditar(double valor);

        public void exibirSaldo()
        {
            Console.WriteLine($"Seu saldo é: {saldo}");
        }

    }
}