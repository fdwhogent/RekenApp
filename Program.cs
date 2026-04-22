namespace RekenApp {
    internal class Program {
        static void Main() {
            // vraag om 2 getallen en druk som op de console
            Console.WriteLine("Voer het eerste getal in:");
            int getal1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Voer het tweede getal in:");
            int getal2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Optellen (+), Vermenigvuldigen (*) of Delen (/)?");
            string actie = Console.ReadLine();
            if (actie == "+") {
                int som = getal1 + getal2;
                Console.WriteLine($"De som van {getal1} en {getal2} is: {som}");
            } else if (actie == "*") {
                int product = getal1 * getal2;
                Console.WriteLine($"Het product van {getal1} en {getal2} is: {product}");
            } else if (actie == "/") {
                if (getal2 == 0) {
                    Console.WriteLine("Delen door nul is niet toegestaan.");
                } else {
                    double quotiënt = (double)getal1 / getal2;
                    Console.WriteLine($"Het quotiënt van {getal1} en {getal2} is: {quotiënt}");
                }
            } else {
                Console.WriteLine("Ongeldige actie.");
            }
        }
    }
}
