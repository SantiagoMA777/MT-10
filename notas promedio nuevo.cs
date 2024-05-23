/******************************************************************************

autor: andres martinez
fecha: 22/05/24
descripcion: promedio de notas
            

*******************************************************************************/
using System;
class HelloWorld {
  static void Main() {
    
    //variables
    double nota1;
    double nota2;
    double nota3;
    double nota4;
   
    
    
    //peticion de datos
    Console.WriteLine("digite su nota:");
    nota1= Double.Parse(Console.ReadLine());
    
    Console.WriteLine("digite la nota 2:");
     nota2= Double.Parse(Console.ReadLine());
    
   Console.WriteLine("digite la nota 3:");
    nota3= Double.Parse(Console.ReadLine());
         
         Console.WriteLine("digite la nota 4:");
         nota4= Double.Parse(Console.ReadLine());
         
         
         if(nota1>=3.0){
         
          Console.WriteLine("felicidades aprobaste con:" + ( nota1 + nota2 + nota3 + nota4 ) / 4 );
         }
          if(nota1<=3.0){
              Console.WriteLine("lo siento has reprobado");
              Console.WriteLine("reprobaste con" + ( nota1 + nota2 + nota3 + nota4 ) / 4 );
          }
               if(nota1>=4.5){
                   
                   Console.WriteLine("te has ganado la beca con un promedio de:" + ( nota1 + nota2 + nota3 + nota4 ) / 4 ); 
               }
               
  } 
}
