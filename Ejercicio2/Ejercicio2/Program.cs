// See https://aka.ms/new-console-template for more information

using Ejercicio2.Clases;

Hueso[] huesos = new Hueso[]
        {
            new Hueso("Hueso 2", 3.5, 5.8, 60.0, 1.0),
            new Hueso("Hueso 3", 4.0, 4.0, 38.42, 4.0),
            new Hueso("Hueso 1", 5.8, 3.6, 50.0, 3.5),
        };

Esqueleto esqueleto = new Esqueleto();
esqueleto.CargarHuesos(huesos);

Console.WriteLine("Esqueleto sin ordenar:");
esqueleto.Imprimir();

Console.WriteLine("Esqueleto ordenado por nombre:");
esqueleto.Ordenar("Nombre");
esqueleto.Imprimir();