using System;

namespace cs_1._22_AreaHexagonoReg
{
    class Program
    {
        static void Main(string[] args)
        {
            double lado, area;

            // Validar o lado.
            do
            {
                Console.Write("Digite o valor do lado do hexágono regular: ");
                lado = double.Parse(Console.ReadLine());
                lado = Math.Abs(lado);

            } while (lado <= 0);

            area = (3 * lado * lado * Math.Sqrt(3)) / 2;

            Console.WriteLine($"\nÁrea do hexágono regular: {area}");
        }
    }
}
