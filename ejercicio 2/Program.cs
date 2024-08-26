namespace ejercicio_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double mayorTamaño = 0;
            int iteracion = 0;
            double Promedio = 0;
            for (int i = 1; i <= 5; i++) 
            {
                 Console.Write("Ingrese el valor de diagonal mayor: ");
                 var DM = int.Parse(Console.ReadLine());
                 Console.Write("Ingrese el valor de diagonal menor: ");
                 var dm = int.Parse(Console.ReadLine());

                 var lado = Math.Sqrt(Math.Pow(DM / 2, 2) + Math.Pow(dm / 2, 2));
                 Console.WriteLine($"Rombo {i}");
                 Console.WriteLine($"El lado del rombo es: {lado}");
                 var perimetro = lado * 4;
                 Console.WriteLine($"El perimetro es: {perimetro}");
                 var superficie = (DM * dm) / 2;
                 Console.WriteLine($"La superficie es: {superficie}");

                Promedio += superficie;
                if (superficie > mayorTamaño)
                {
                    mayorTamaño=superficie;
                    iteracion=i; 
                }
                Promedio /= 5;
                Console.WriteLine($"Promedio de superficie: {Promedio}");
                Console.WriteLine($"Mayor superficie: {mayorTamaño}");
                Console.WriteLine($"Ingresada en iteracion nro: {iteracion}");
            }
        }
    }
}
