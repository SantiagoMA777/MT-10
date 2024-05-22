/******************************************************************************

autor: andres martinez
fecha: 22/05/24
descripcion:  programas con descripcion para habilitar 
             votacion de personas
            

*******************************************************************************/
using System;
class HelloWorld {
  static void Main() {
    
    //variables
    int edad;
    int valorMatricula;
    
    //peticion de datos
    Console.WriteLine("digite su edad:");
    edad= Int32.Parse(Console.ReadLine());
    
    Console.WriteLine("digite su valor de matricula:");
    valorMatricula = Int32.Parse(Console.ReadLine());
    
    //VALIDACION
    
         if(edad>=18){
         Console.WriteLine("felicidades, usted puede votar");
          Console.WriteLine("usted pagara de matricula:" + (valorMatricula* 0.85 ));
    }
  }
}