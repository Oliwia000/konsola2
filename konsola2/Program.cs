using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine($"Liczba zarejestrowanych osób to {Osoba.LiczbaInstancji}");
        Osoba osoba1 = new Osoba();

        // Tworzenie klasy osoba za pomocą konstruktora z dwoma parametrami.
        Console.Write("Wprowadź id: ");
        int id = int.Parse(Console.ReadLine());
        Console.Write("Wprowadź imię: ");
        string imie = Console.ReadLine();
        Osoba osoba2 = new Osoba(id, imie);

        // Tworzenie klasy osoba za pomocą konstruktora kopiującego.
        Osoba osoba3 = new Osoba(osoba2);

        osoba1.WypiszImie("Jan");
        osoba2.WypiszImie("Jan");
        osoba3.WypiszImie("Jan");

        Console.WriteLine($"Liczba zarejestrowanych osób to {Osoba.LiczbaInstancji}");
    }}
public class Osoba
{
    private int id;
    private string imie;

         /// <summary>
         /// Statyczne pole zliczające liczbę instancji osoby.
         /// </summary>
    public static int LiczbaInstancji { get; private set; } = 0;

             /// <summary>
            /// ustawia wartości domyślne dla pól.
           /// </summary>
    public Osoba()
    {
        id = 0;
        imie = string.Empty;
        LiczbaInstancji++;
    }

           /// <summary>
          /// Konstruktor,ustawia wartości dla pól id i imie.
         /// </summary>
        /// <param name="id">identyfikator osoby.</param>
       /// <param name="imie">imię osoby.</param>
    public Osoba(int id, string imie)
    {
        this.id = id;
        this.imie = imie;
        LiczbaInstancji++;
    }

    /// <summary>
    /// Konstruktor kopiujący, tworzy nową instancję na podstawie innej.
    /// </summary>
    /// <param name="innaOsoba">Inna instancja klasy Osoba.</param>
    public Osoba(Osoba innaOsoba)
    {
        this.id = innaOsoba.id;
        this.imie = innaOsoba.imie;
        LiczbaInstancji++;
    }

    /// <summary>
    /// Metoda do wypisania imienia obiektu klasy osoba.
    /// </summary>
    /// <param name="inneImie">Imię osoby, do której kierowany jest komunikat.</param>
    public void WypiszImie(string inneImie)
    {
        if (string.IsNullOrEmpty(imie))
        {
            Console.WriteLine("Brak danych");
        }
        else
        {
            Console.WriteLine($"Cześć {inneImie}, mam na imię {imie}");
        }
    }
}


