public class Match
{
    // Privata fält
    private string _hemmalag;
    private string _bortalag;
    private DateTime _datum;

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

    public DateTime Datum
    {
        // get och privat set för Datum
        get { return _datum;}
        private set { _datum = value; }
    }

    // Pluspoäng om ni kommer på hur man kan minska ner koden med properties :)

    // Konstruktor
    public Match(string hemmalag, string bortalag)
    {
        // TODO: tilldela de privata fälten
        _hemmalag = hemmalag;
        _bortalag = bortalag;
        _datum = DateTime.Now;
    }

    // Metod 1: skriv ut matchens lag och datum
    public void Presentera()
    {
        // TODO
    }

    // Metod 2: skriv ut spelarens namn, nummer och position
    public void AnnounceraMålskytt(Spelare spelare)
    {
        // TODO
    }
}
