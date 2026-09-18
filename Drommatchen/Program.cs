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

        Spelare spelare1 = new Spelare("Ivar the Great", 9, "Yttermittfältare");
        Spelare spelare2 = new Spelare("Carl Gustav XII", 67, "Målvakt");

        Match match1 = new Match("Drömlagen", "FortniteElites");


        match1.Presentera();

        Console.WriteLine("---");

        match1.AnnounceraMålskytt(spelare1);


    }
}