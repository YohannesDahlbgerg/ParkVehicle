using System;
using System.Collections.Generic;

// Parkeringsplatser
List<string>[] parkingSpot = new List<string>[101];


for (int i = 0; i < parkingSpot.Length; i++)
{
    parkingSpot[i] = new List<string>();  // Skapar en lista för varje parkeringsruta
}

// Anropa metoden ParkVehicle
ParkVehicle();


Console.WriteLine("Tryck på Enter för att avsluta.");
Console.ReadLine();

void ParkVehicle()
{
    
    Console.Write("Ange registreringsnummer: ");
    string Regnummer = Console.ReadLine();

    // Om inget registreringsnummer har angetts
    if (string.IsNullOrWhiteSpace(Regnummer))
    {
        Console.WriteLine("Inget registreringsnummer angivet.");
        return;  
    }

    
    if (Regnummer.StartsWith("MC") || Regnummer.StartsWith("CAR"))
    {
        Console.WriteLine("Registreringsnumret är giltigt.");

        // Hitta en ledig plats för att parkera fordonet
        for (int i = 0; i < parkingSpot.Length; i++)
        {
            
            if (parkingSpot[i].Count == 0)
            {
                parkingSpot[i].Add(Regnummer);  // Parkera fordonet
                Console.WriteLine($"Fordonet har parkerats på plats {i + 1}.");
                return;  
            }
        }

        
        Console.WriteLine("Det finns ingen ledig parkeringsplats.");
    }
    else
    {
        Console.WriteLine("Var vänlig att ge ett giltigt regnummer.");
    }
}
