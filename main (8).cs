/******************************************************************************

autor: andres martinez
fecha: 22-05-24
descripcion: programas con decisiones

*******************************************************************************/
using System;
class programa {
  static void Main(){
    //variables
    bool sexoMasculino;
    //capturar informacion del usuario
    Console.Write("Digite true si es hombre ");
    sexoMasculino = Convert.ToBoolean (Console.ReadLine());
    //validacion
    if (sexoMasculino == true)
    {
        Console.WriteLine("Felizidades, es hombre");
    }
    else{
        Console.WriteLine("Felizidades, es mujer");
    }
       Console.WriteLine("finalizada la ejecucion");
  }
}
