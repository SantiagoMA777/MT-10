/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
class HelloWorld {
  static void Main() {
      // variables
      int juguetesEncontrados = 0;
     
    // estructura repetitiva o ciclicla
     int i = 0;
     while (i < 4){

    // preguntar ubicaciones al usuario
    Console.WriteLine("Ronda " + (i+1) + " ¿donde deberiamos buscar?");
    Console.WriteLine("sala,dormitorio,cocina,sotano,balcon");
    string lugar = Console.ReadLine().ToLower();
   
    // validar ubicaciones con estructura IF
   
    if (lugar == "sotano"){
        Console.WriteLine("Encontramos dos juguete en el sotano");
        juguetesEncontrados++;
        juguetesEncontrados++;
    }
     
    else if (lugar == "cocina"){
        Console.WriteLine("Encontramos un juguete en la cocina");
        juguetesEncontrados++;
    }
   
    else if (lugar == "sala"){
        Console.WriteLine("Encontramos dos juguete en la sala");
        juguetesEncontrados++;
        juguetesEncontrados++;
    }
   
    else if (lugar == "balcon"){
        Console.WriteLine("No encontramos ningun juguete en el balcon");
    }  
   
    else if (lugar == "dormitorio"){
    Console.WriteLine("No encontramos ningun juguete en el dormitorio");
    }
    else {
          Console.WriteLine("ubicacion no valida");
    }    
      i++;    
    }
      Console.WriteLine("total de juguetes encontrados: " + juguetesEncontrados);
      }  
    }
