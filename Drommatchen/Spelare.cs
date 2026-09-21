public class Spelare
{
    // Privata fält
    private string _namn;
    private int _nummer;
    private string _position;
    private int _mål;

    // Properties — publik get, privat set
    public string Namn
    {
        // Skapa get och privat set för Namn
        get { return _namn; }
        private set { _namn = value; }
    }

    public int Nummer
    {
        // Skapa get och privat set för Nummer
        get { return _nummer; }
        private set { _nummer = value; }
    }

    public string Position
    {
        // Skapa get och privat set för Position
        get { return _position; }
        private set
        {

            _position = value;
        }
    }

    //Ny property för VG
    public int Mål
    {
        get { return _mål; }
        private set { _mål = value; }
    }

    // Konstruktor

    //Lade till int mål i konstruktor
    public Spelare(string namn, int nummer, string position, int mål)
    {
        // TODO: tilldela de privata fälten
        _namn = namn;
        _nummer = nummer;
        _position = position;
        _mål = mål;
    }

    //Metod för att se om en spelare blir matchhälte, bara om spelaren gör mer än ett mål.

    public bool ÄrMatchHjälte()
    {
        if (Mål > 1)
        {
            Console.WriteLine($"Matchhjälte för matchen är {Namn} med {Mål} mål");
            return true;

        }
        Console.WriteLine($"Tyvärr inte matchhjälte för denna gång, {Namn} med {Mål} mål");
        return false;
    }

    public override string ToString()
    {

        //Skapa en toStringmetod, (fick utskrift i terminal "Spelare" av konstruktorn och inte dess parameterar)

        return $"GOOLAZOOO! {Namn}  #{Nummer}  {Position}";

    }

}
