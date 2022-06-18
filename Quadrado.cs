namespace Atividade07_POO
{
    public class Quadrado : Forma
    {

        public override void Calcular()
        {
            Console.WriteLine("Digite a medida de um dos lados: ");
            double baseQuadrado = Convert.ToDouble(Console.ReadLine());

            double calculoQuadrado = baseQuadrado * baseQuadrado;
            Console.WriteLine($"A dimensão do seu quadrado é: {calculoQuadrado}");
        }
    }
}
