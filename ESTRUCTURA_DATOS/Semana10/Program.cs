using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // Creamos un conjunto  de 500 ciudadanos con identificadores del 1 al 500
        HashSet<int> ciudadanos = new HashSet<int>(Enumerable.Range(1, 500));

        // Creamos un conjunto ficticio de 75 ciudadanos vacunados con Pfizer (ID del 1 al 75)
        HashSet<int> vacunadosPfizer = new HashSet<int>(Enumerable.Range(1, 75));

        // Crear un conjunto ficticio de 75 ciudadanos vacunados con AstraZeneca (ID del 76 al 150)
        HashSet<int> vacunadosAstraZeneca = new HashSet<int>(Enumerable.Range(76, 75));

        // Operaciones de conjuntos
        var noVacunados = ciudadanos.Except(vacunadosPfizer).Except(vacunadosAstraZeneca).ToList();
        var vacunadosAmbas = vacunadosPfizer.Intersect(vacunadosAstraZeneca).ToList();
        var soloPfizer = vacunadosPfizer.Except(vacunadosAstraZeneca).ToList();
        var soloAstraZeneca = vacunadosAstraZeneca.Except(vacunadosPfizer).ToList();

        // Mostramos cantidad de ciudadanos en cada grupo
        MostrarResultados("No vacunados", noVacunados.Count);
        MostrarResultados("Vacunados con ambas vacunas", vacunadosAmbas.Count);
        MostrarResultados("Vacunados solo con Pfizer", soloPfizer.Count);
        MostrarResultados("Vacunados solo con AstraZeneca", soloAstraZeneca.Count);

        // Mostramos los primeros 10 ciudadanos de cada grupo
        MostrarPrimeros("No vacunados", noVacunados);
        MostrarPrimeros("Vacunados con ambas vacunas", vacunadosAmbas);
        MostrarPrimeros("Vacunados solo con Pfizer", soloPfizer);
        MostrarPrimeros("Vacunados solo con AstraZeneca", soloAstraZeneca);
    }

    // Método para mostrar resultados por cantidad
    static void MostrarResultados(string categoria, int cantidad)
    {
        Console.WriteLine($"{categoria}: {cantidad} ciudadanos");
    }

    // Método para mostrar los primeros 10 ciudadanos de cada categoría
    static void MostrarPrimeros(string categoria, List<int> lista)
    {
        Console.WriteLine($"\nPrimeros 10 ciudadanos en la categoría '{categoria}':");
        foreach (var ciudadano in lista.Take(10))
        {
            Console.WriteLine($"ID: {ciudadano}");
        }
    }
}
