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
        get;
        private set;
    }

    public string Bortalag
    {
        // get och privat set för Bortalag
        get;
        private set;
    }

    public string Datum
    {
        // get och privat set för Datum
        get { 
            return _datum;
            }
        private set 
            {
            _datum = value;
            }
    }

    // Pluspoäng om ni kommer på hur man kan minska ner koden med properties :)

    // Konstruktor
    public Match(string hemmalag, string bortalag)
    {
        // TODO: tilldela de privata fälten
        Hemmalag = hemmalag;
        Bortalag = bortalag;
        
        
    }

    // Metod 1: skriv ut matchens lag och datum
    public void Presentera()
    {
        // TODO
        Console.WriteLine($"Dagens match: {Hemmalag} VS {Bortalag}");
        
    }

    // Metod 2: skriv ut spelarens namn, nummer och position
    public void AnnounceraMålskytt(Spelare spelare)
    {
        // TODO
    }
}
