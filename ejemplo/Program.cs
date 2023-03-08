using System;

namespace ejemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite el nombre de la persona");
            persona perso;
            string a = Console.ReadLine();
            perso = new persona(a.ToUpper(), 45, 80);
            perso.comer(150);
            perso.Caminar(10);
            perso.comer(1500);
            perso.MontarBici(100);
            perso.finalizardia();
            Console.WriteLine(perso.getPeso());
            perso.despertar();
            perso.comer(150);
            perso.Caminar(10);
            perso.comer(2900);
            perso.MontarBici(100);
            perso.finalizardia();
            perso.dormir();
            perso.MontarBici(1500);
            perso.finalizardia();
            Console.WriteLine(perso.getPeso());
        }
    }
}
