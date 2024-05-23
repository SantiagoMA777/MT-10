/******************************************************************************

Autor:  andres martinez
fecha: 23/05/24
descripcion: tony stark
*******************************************************************************/
using System;
     class HelloWorld {
     static void Main() {
         
          //variables
         int cantidadTornillos;
         int valorTornillos;
         
           //peticion de datos
           Console.WriteLine("ingrese la cantidad de tornillos");
           cantidadTornillos= Int32.Parse(Console.ReadLine());
           valorTornillos= 300;
           //validacion
           
         if (cantidadTornillos >= 5){
               Console.WriteLine("el valor del tornillo es "+ (valorTornillos * 0.70));
             }
           
           
        
           //validacion
           
         if (cantidadTornillos >= 10){
               Console.WriteLine("el valor del tornillo es "+ (valorTornillos * 0.50));
               Console.WriteLine("el valor del tornillo es "+ (valorTornillos * 0.50*cantidadTornillos));
         }
               
           
          }
     }
