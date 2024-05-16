/******************************************************************************
Autor: Juan Arango y andres martinez
Fecha creacion: 2024-05-16
descripcion: los avenger necesitan  un programa en c# para calcular la fuerza necesaria
para levantar un objeto en el planeta marte. completa el  espacio en blanco para solicitar al usuario 
la masa del objeto a levantar 
*******************************************************************************/
using System;
class HelloWorld {
  static void Main() {
    Console.WriteLine("Ingrese la masa del objeto a levantar en kilogramos:");
        double masaObjeto = double.Parse(Console.ReadLine());
        double gravedad = 3.71; 
        double fuerza = masaObjeto * gravedad;
        Console.WriteLine("La fuerza necesaria para levantar el objeto es de aproximadamente " + fuerza + " Newtons");
    
}
  
}