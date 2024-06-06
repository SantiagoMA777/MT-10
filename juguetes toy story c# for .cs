/******************************************************************************

autor: andres maritnez
fecha: 6/06/24
descripcion: Los juguetes de Andy están 
     jugando a las escondidas. Pide al 
     usuario las ubicaciones donde buscar 
     y usa estructuras "si" para determinar 
     si los juguetes están en la ubicación 
     correcta o no. Reportar la cantidad 
     total de juguetes que fueron encontrados 
     al finalizar 4 rondas.

*******************************************************************************/





using System;


class HelloWorld {
    static void Main() {
       
        int juguetesEncontrados = 0;
       
       
        for (int i = 0; i < 4; i++) {
           
           
            Console.WriteLine("Ronda " + (i+1) + ": ¿Dónde deberíamos buscar?");
            Console.WriteLine("Opciones: sotano, sala, cocina, patio");
            string ubicacion = (Console.ReadLine());
           
           
            if (ubicacion == "sotano") {
                Console.WriteLine("¡Encontramos un juguete en la pieza!");
                juguetesEncontrados++;
            }
            else if (ubicacion == "sala") {
                Console.WriteLine("¡Encontramos dos juguetes en la sala!");
                juguetesEncontrados++;
                juguetesEncontrados++;
            }
            else if (ubicacion == "cocina") {
                Console.WriteLine("No hay juguetes en la cocina.");
             }
            else if (ubicacion == "patio") {
                Console.WriteLine("¡Encontramos un juguete en el patio!");
                juguetesEncontrados++;
            }
            else {
                Console.WriteLine("Ubicación no válida.");
            }
        }
}
}

