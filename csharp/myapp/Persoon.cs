// See https://aka.ms/new-console-template for more information
using System.Runtime.CompilerServices;

Console.WriteLine("Hello, World!");

class Persoon
{
    public string? naam { get; set; }
    private int leeftijd { get; set; }
    protected char geslacht { get; set; }
    public bool isStudent { get; set; }
    public double gemiddeldCijfer { get; set; }

    public Persoon(string naam, int leeftijd, char geslacht, bool isStudent, double gemiddeldCijfer)
    {
        this.naam = naam;
        this.leeftijd = leeftijd;
        this.geslacht = geslacht;
        this.isStudent = isStudent;
        this.gemiddeldCijfer = gemiddeldCijfer;
    }
}