/******************************************************************************
Fecha:          29-05-2024
Descripción:    Ejercicio estructura de decisión múltiple
Se desea un programa que ayude diciendo 
las preferencias según el género:
- Si es un hombre menor de edad sus preferencias son:
    Figuras de acción, Caricaturas, Series TV
- Si es un hombre mayor de edad sus preferencias son:
    cine, picnic y filantropía
- Si es una mujer menor de edad sus preferencias son:
    Muñecas, Maquillaje, Series TV
- Si es una mujer mayor de edad sus preferencias son:
    Maquillaje, Series TV, Cine, filantropía


*******************************************************************************/
using System;

class Program
{
    static void Main()
    {
        
        Console.WriteLine("Ingrese su género (hombre/mujer): ");
        string genero = Console.ReadLine();

        
        Console.WriteLine("Ingrese su edad: ");
        int edad = int.Parse(Console.ReadLine());

    
        if (genero == "hombre")
        {
            if (edad < 18)
            {
                Console.WriteLine("Sus preferencias son: Figuras de acción, Caricaturas, Series TV");
            }
            else
            {
                Console.WriteLine("Sus preferencias son: Cine, Picnic, Filantropía");
            }
        }
         if (genero == "mujer")
        {
            if (edad < 18)
            {
                Console.WriteLine("Sus preferencias son: Muñecas, Maquillaje, Series TV");
            }
            else
            {
                Console.WriteLine("Sus preferencias son: Maquillaje, Series TV, Cine, Filantropía");
            }
        }
        
        
            
        
    }
}

