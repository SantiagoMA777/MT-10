/******************************************************************************

autor: andres martinez
fecha: 30/05/2024
descripcion:  programa aprendizaje estructura switch

*******************************************************************************/
using System;
class HelloWorld {
  static void Main() {
      Console.WriteLine("digite un numero del (1-7), luego enter");
      Console.WriteLine("opcion");
    int opcion = Int32.Parse(Console.ReadLine());
switch (opcion)
{
  case 1:
    Console.WriteLine("lunes");
    break;
  case 2:
    Console.WriteLine("martes");
    break;
  case 3:
    Console.WriteLine("miercoles");
    break;
  case 4:
    Console.WriteLine("jueves");
    break;
  case 5:
    Console.WriteLine("viernes");
    break;
  case 6:
    Console.WriteLine("sabado");
    break;
  case 7:
    Console.WriteLine("domingo");
    break;
}
  }
}
