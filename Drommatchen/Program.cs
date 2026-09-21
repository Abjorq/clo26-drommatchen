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



        Match match1 = new Match("Drömlagent", "FortniteElites", "2026-09-13");

        Spelare spelare1 = new Spelare("Ivar the Great", 9, "Yttermittfältare", 1);
        Spelare spelare2 = new Spelare("Carl Gustav XII", 67, "Målvakt", 2);

        match1.Presentera(match1);
        Console.WriteLine();
        match1.AnnounceraMålskytt(spelare1);
        match1.AnnounceraMålskytt(spelare2);
        Console.WriteLine();
        spelare1.ÄrMatchHjälte();
        spelare2.ÄrMatchHjälte();


    }
}