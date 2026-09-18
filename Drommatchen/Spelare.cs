public class Spelare
{
    // Privata fält
    private string _namn;
    private int _nummer;
    private string _position;

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
        private set { _position = value; }
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

        return $"GOOLAZOOO! {_namn}  nummer: {_nummer}  {_position}";
        
    }
    
}
