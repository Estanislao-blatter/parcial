namespace ejercicio_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double mayorTamaño = 0;
            int iteracion = 0;
            double Promedio = 0;
            int DM, dm;
            for (int i = 1; i <= 5; i++) 
            {
                do
                {
                    Console.Write("Ingrese el valor de diagonal mayor: ");
                    if (int.TryParse(Console.ReadLine(), out DM)&& DM>0)
                    {
                        break;
                    }
                    Console.WriteLine("Diagonal mal ingresada...");
                } while (true);
                do
                {
                    Console.Write("Ingrese el valor de diagonal menor: ");
                    if (int.TryParse(Console.ReadLine(), out dm) && (dm > 0 && dm<DM))
                    {
                        break;
                    }
                    Console.WriteLine("Diagonal mal ingresada...");
                } while (true);

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
