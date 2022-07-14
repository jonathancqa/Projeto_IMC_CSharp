using System;

namespace IMC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com o peso: ");
            float peso = (float)Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Entre com altura: ");
            float altura = (float)Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Qual sua idade: ");
            string idade = Console.ReadLine();

            Console.WriteLine("Peso da pessoa: " + peso);
            Console.WriteLine($"Altura da pessoa: {altura}");
            Console.WriteLine($"Sua idade é: {idade}");

            double result = peso / (altura * altura);

            if(result < 18)
            {
                Console.WriteLine("Você está abaixo do peso.");
            }
            else if (result > 18 && result < 25)
            {
                Console.WriteLine("Seu peso está normal.");
            }
            else if (result > 25 && result < 30)
            {
                Console.WriteLine("Você está acima do peso.");
            }
        }
    }
}
