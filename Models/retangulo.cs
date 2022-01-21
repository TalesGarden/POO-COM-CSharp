namespace exemploPOO.Models
{
    public class Retangulo
    {
        private double comprimento;
        private double largura;

        public bool DefineMedidas(int comprimento, int largura){

            if (comprimento <= 0 || largura <=0)
            {
                throw new ArgumentException("Medidas não podem ser negativas");
                
            }
            this.comprimento = comprimento;
            this.largura = largura;
            return true;
        }

        public void exibeArea()
        {
            var area = this.comprimento * this.largura;
        }

        public double ObterArea()
        {
            return this.comprimento *  this.largura;
        } 
    }
}