/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;

class Program
{
    static void Main()
    {
        
        Console.WriteLine(CalcularCostoTornillos(3));  
        Console.WriteLine(CalcularCostoTornillos(6));  
        Console.WriteLine(CalcularCostoTornillos(12));
    }

    static double CalcularCostoTornillos(int cantidadTornillos)
    {
        const double PRECIO_UNITARIO = 300;
        double costoTotal;

        if (cantidadTornillos < 5)
        {
            costoTotal = cantidadTornillos * PRECIO_UNITARIO;
        }
        else if (cantidadTornillos >= 5 && cantidadTornillos < 10)
        {
            costoTotal = cantidadTornillos * PRECIO_UNITARIO * 0.7;
        }
        else 
        {
            costoTotal = cantidadTornillos * PRECIO_UNITARIO * 0.5; 
        }

        return costoTotal;
    }
}