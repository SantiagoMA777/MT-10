/******************************************************************************

autor: andres martinez
fecha: 30/05/2024
descripcion:  programa aprendizaje estructura switch

*******************************************************************************/
using System;
class HelloWorld {
  static void Main() {
      Console.WriteLine("dijita un numero de menu (1-4), luego enter");
      Console.WriteLine("opcion ");
      int opcion = Int32.Parse(Console.ReadLine());
      switch(opcion)
      {
       case  1:
            Console.WriteLine("entro a la opcion 1 ");
         break;
       case  2:
            Console.WriteLine("entro a la opcion 2 ");
         break;
       case 3:
           Console.WriteLine("entro a la opcion 3 ");
           break;
       case 4:
           Console.WriteLine("entro a la opcion 4 ");
           break;
       default:
            Console.WriteLine("opcion no valida ");
            Console.WriteLine("saliendo del programa... ");
         break;
}
  }
}
