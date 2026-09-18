// TODO: Skapa minst 2 spelare
// Spelare spelare1 = new Spelare("Namn", nummer, "Position");
// Spelare spelare2 = new Spelare(...);

// TODO: Skapa 1 match
// Match match = new Match("Hemmalag", "Bortalag", "Datum");

// TODO: Anropa match.Presentera()

// TODO: Anropa match.AnnounceraMålskytt() med båda spelarna

class Program
{

    static void Main()
    {

        Match match1 = new Match("Drömlagen", "FortniteElites");

        Spelare spelare1 = new Spelare("Ivar the Great", 9, "Yttermittfältare");

        match1.Presentera();

        Console.WriteLine("---");

        


    }
}