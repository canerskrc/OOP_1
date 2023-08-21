// C# program to illustrate the
// Initialization of an object
using System;

// Class Declaration
public class Egitmen
{

    // Instance Variables
    String isim;
    String alan;
    int yas;
    int tecrube;

    // Constructor Declaration of Class
    public Egitmen(String isim, String alan,
                int yas, int tecrube)
    {
        this.isim = isim;
        this.alan = alan;
        this.yas = yas;
        this.tecrube = tecrube;
    }

    // Property 1
    public String GetAd()
    {
        return isim;
    }

    // Property 2
    public String GetAlan()
    {
        return alan;
    }

    // Property 3
    public int GetYas()
    {
        return yas;
    }

    // Property 4
    public int GetTecrube()
    {
        return tecrube;
    }

    // Method 1
    public String ToString()
    {
        return ("MErhaba adim " + this.GetAd()
                + ".\nBenim uzmanlık alanım " + this.GetAlan() 
                + " Yasım" + this.GetYas() + "bu alanda tecrubem " + this.GetTecrube() 
                + " yıl.");
    }

    // Main Method
    public static void Main(String[] args)
    {

        // Creating object
        Egitmen cnr = new Egitmen("Caner Sekerci", "yapay zeka", 27, 8);
        Console.WriteLine(cnr.ToString());
    }
}
