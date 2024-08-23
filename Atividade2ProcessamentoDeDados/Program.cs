namespace Atividade2ProcessamentoDeDados
{
    internal class Program
    {
        static void Main(string[] args)
        {  //Crie uma variável a, b e c todas do tipo int e atribua os valores 1, 12 e -13
           // respectivamente a elas, depois realize o cálculo da fórmula de baskara e
            //exiba os resultados de delta, x1 e x2

            //Declaração das variáveis
          int a = 1, b = 12, c = -13;

            // Calcúlo de Delta
            double delta = Math.Pow(b, 2) - 4 * a * c;

            // Cálculo das raízes x1 e x2
            double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
            double x2 = (-b - Math.Sqrt(delta)) / (2 * a);

            // exiba os resultados 
            Console.WriteLine($"Delta: {delta}");
            Console.WriteLine($"x1: {x1}");
            Console.WriteLine($"x2: {x2}");


            // Se delta for negativo, não há raízes reais
            Console.WriteLine("Não há raízes, pois delta é negativo.");


        }
    }
}
