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

    public int Mål
    {
        get
        {
            return _mål;
        }
        private set
        {
            _mål = value;
        }
    }

    // Konstruktor
    public Spelare(string namn, int nummer, string position)
    {
        // TODO: tilldela de privata fälten
        _namn = namn;
        _nummer = nummer;
        _position = position;
    }

    public override string ToString()
    {

        //Skapa en toStringmetod, (fick utskrift i terminal "Spelare" av konstruktorn och inte dess parameterar)

        return $"GOOLAZOOO! {Namn}  #{Nummer}  {Position}";

    }

}
