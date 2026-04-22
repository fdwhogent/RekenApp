namespace RekenApp {
    internal class Program {
        static void Main() {
            // vraag om 2 getallen en druk som op de console
            Console.WriteLine("Voer het eerste getal in:");
            int getal1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Voer het tweede getal in:");
            int getal2 = Convert.ToInt32(Console.ReadLine());
            int som = getal1 + getal2;
            Console.WriteLine($"De som van {getal1} en {getal2} is: {som}");
        }
    }
}
