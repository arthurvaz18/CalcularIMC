using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condicao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe o seu Peso");
            double peso = double.Parse(Console.ReadLine());

            Console.Write("Informe a sua altura");
            double altura = double.Parse(Console.ReadLine());

            double IMC = peso / (altura * altura);

            if (IMC < 20)
            {
                Console.WriteLine("A baixo do Peso IMC: " + IMC);
            }
            else if (IMC < 25)
            {
                Console.WriteLine("Peso Normal IMC: " + IMC);
            }
            else if (IMC < 30)
            {
                Console.WriteLine("Sobrepeso IMC:  " + IMC);
            }
            else
            {
                Console.WriteLine("Muito Acima IMC: ");
            }

        }
    }
}