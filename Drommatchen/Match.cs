public class Match
{
    // Privata fält
    private string _hemmalag;
    private string _bortalag;
    private string _datum;

    // Properties — publik get, privat set
    public string Hemmalag
    {
        // get och privat set för Hemmalag 
        get { return _hemmalag; }
        private set { _hemmalag = value; }
    }

    public string Bortalag
    {
        // get och privat set för Bortalag
        get { return _hemmalag; }
        private set { _hemmalag = value; }

    }

    public string Datum
    {
        // get och privat set för Datum
        get { return _datum; }
        private set { _datum = value; }
    }

    // Pluspoäng om ni kommer på hur man kan minska ner koden med properties :)

    // Konstruktor
    public Match(string hemmalag, string bortalag, string datum)
    {
        // TODO: tilldela de privata fälten
        _hemmalag = hemmalag;
        _bortalag = bortalag;
        _datum = datum;


    }

    // Metod 1: skriv ut matchens lag och datum
    public void Presentera(Match match1)
    {
        // TODO
        //Console.WriteLine($"Dagens match: {_hemmalag} VS {_bortalag}");
        Console.WriteLine(match1);

    }

    // Metod 2: skriv ut spelarens namn, nummer och position
    // Använd metod på det matchobjekt om spelare gjort mål med argument spelareobjekt.
    public void AnnounceraMålskytt(Spelare enSpelare)
    {
        // TODO
        Console.WriteLine(enSpelare);

        if (enSpelare.Position == "Målvakt")
        {
            Console.WriteLine($"Jag kan inte tro mina ögon! Målvakten gjorde mål");
        }

    }

    public override string ToString()
    {
        return $"{Hemmalag} VS {Bortalag} - {Datum}";
    }

}
