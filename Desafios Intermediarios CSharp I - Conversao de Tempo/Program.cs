using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafios_Intermediarios_CSharp_I___Conversao_de_Tempo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var timeInSeconds = int.Parse(Console.ReadLine());
            //TODO: Implementar a formula para calcular as horas.
            var hours = timeInSeconds / 3600;
            timeInSeconds = timeInSeconds % (3600);
            //TODO: Implementar a formula para calcular as horas.
            var minutes = timeInSeconds / 60;
            var seconds = timeInSeconds % 60;

            Console.WriteLine($"{hours}:{minutes}:{seconds}");


        }
    }
}
