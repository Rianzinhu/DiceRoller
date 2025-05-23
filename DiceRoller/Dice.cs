
namespace DiceRoller
{
    public class Dice
    {
        //Atributos - utilizamos property nesse caso. (public tipo Nome)
        public int FaceParaBaixo;
        public int FaceParaCima;
        public int QuantidadeDeFaces;

        public Dice()
        {
            QuantidadeDeFaces = 6;
        }
        public Dice(int faces)
        {
            QuantidadeDeFaces = faces;
        }

        //Método responsável por sortear um número
        public void Sortear()
        {
            //Gero um numero aleatório de 1 a 6
            Random random = new Random();
            //Jogo esse número na face para cima
            FaceParaCima = random.Next(1,QuantidadeDeFaces + 1);
            // A soma mágica = o menor lado possível + o maior
            // A soma mágica = 1 + quantidadeDeFaces
            FaceParaBaixo = QuantidadeDeFaces + 1 - FaceParaCima;
            //Calcular a face para baixo
        }

    }
}
