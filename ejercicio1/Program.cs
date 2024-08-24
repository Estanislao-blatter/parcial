namespace ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el valor de diagonal mayor: ");
            var DM=int.Parse(Console.ReadLine());
            Console.Write("Ingrese el valor de diagonal menor: ");
            var dm=int.Parse(Console.ReadLine());

            var lado = Math.Sqrt(Math.Pow(DM/2,2) + Math.Pow(dm/2,2));
            Console.WriteLine($"El lado del rombo es: {lado}");
            var perimetro = lado * 4;
            Console.WriteLine($"El perimetro es: {perimetro}");
            var superficie = (DM * dm )/ 2;
            Console.WriteLine($"La superficie es: {superficie}");
        }
    }
}
