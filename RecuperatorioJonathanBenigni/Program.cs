namespace RecuperatorioJonathanBenigni
{
    using System;

    class Program
    {
        static double CalcularDiagonal(double largo, double ancho, double altura)
        {
            return Math.Sqrt(Math.Pow(largo, 2) + Math.Pow(ancho, 2) + Math.Pow(altura, 2));
        }

        static double CalcularVolumen(double largo, double ancho, double altura)
        {
            return largo * ancho * altura;
        }

        static double CalcularArea(double areaBase, double areaAltura, double areaAncho)
        {
            return 2 * (areaBase + areaAltura + areaAncho);
        }

        static double CalcularAreaAltura(double altura, double ancho)
        {
            return altura * ancho;
        }

        static double CalcularAreaAncho(double altura, double largo)
        {
            return altura * largo;
        }

        static double CalcularAreaBase(double largo, double ancho)
        {
            return largo * ancho;
        }

        static void Main(string[] args)
        {
            int contador = 0;
            double largo, altura, ancho;

            Console.WriteLine("Bienvenido a Prismas Rectangulares Rectos");

            do
            {
                Console.Write("Ingrese el Largo del Prisma: ");
                largo = Convert.ToDouble(Console.ReadLine());

                Console.Write("Perfecto, ahora ingrese la Altura del Mismo: ");
                altura = Convert.ToDouble(Console.ReadLine());

                Console.Write("Y por último, ingrese el Ancho de este: ");
                ancho = Convert.ToDouble(Console.ReadLine());

                if (largo > 0 && altura > 0 && ancho > 0)
                {
                    double areaBase = CalcularAreaBase(largo, ancho);
                    double areaAltura = CalcularAreaAltura(altura, ancho);
                    double areaAncho = CalcularAreaAncho(altura, largo);
                    double area = CalcularArea(areaBase, areaAltura, areaAncho);
                    double volumen = CalcularVolumen(largo, ancho, altura);
                    double diagonal = CalcularDiagonal(largo, ancho, altura);

                    Console.WriteLine("El Área del Prisma es: " + area);
                    Console.WriteLine("El Volumen del Prisma es: " + volumen);
                    Console.WriteLine("La Diagonal del Prisma es: " + diagonal);

                    contador++;
                }
                else
                {
                    Console.WriteLine("Los valores ingresados son iguales o menores a 0.");
                }
            } while (largo != 0);

            Console.WriteLine("La cantidad de Prismas Correctos fue de: " + contador);
        }
    }

}