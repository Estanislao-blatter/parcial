using ejercicio3.entidades;

namespace ejercicio_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el valor de diagonal mayor: ");
            var DM = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el valor de diagonal menor: ");
            var dm = int.Parse(Console.ReadLine());
            Rombo r = new Rombo(DM,dm);
            Console.WriteLine(r.GetInfo());
        }
    }
}
