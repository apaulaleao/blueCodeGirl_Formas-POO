namespace Atividade07_POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual forma você deseja calcular?");
            Console.WriteLine("1 - Quadrado");
            Console.WriteLine("2 - Triangulo");
            Console.WriteLine("3 - Circulo");
            
            string Alternativa = Console.ReadLine();

            switch(Alternativa)
            {
                case "1":
                        Quadrado quadrado = new Quadrado();
                        quadrado.Calcular();
                    break;

                case "2":
                        Circulo circulo = new Circulo();
                        circulo.Calcular();
                break;

                case "3":
                        Triangulo triangulo = new Triangulo();
                    triangulo.Calcular();
                break;

                default:
                    Console.WriteLine("Digite um valor válido.");
                break;
            }
        }
    }
}