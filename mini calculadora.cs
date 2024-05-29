/******************************************************************************

autor: andres martinez
fecha: 29/05/24
app con menu


*******************************************************************************/
using System;
using System.Threading;

class HelloWorld {
  static void Main() {
    
                     Console.WriteLine("Hola señor usurario" + "como se encuentra");
 
  
  
  
  Console.WriteLine("|  \\/  | __ _| |_ ___ _ __ ___   /_/_| |_(_) ___ __ _ ___       ");
Console.WriteLine("| |\\/| |/ _` | __/ _ \\ '_ ` _ \\ / _` | __| |/ __/ _` / __|      ");  
Console.WriteLine("| |  | | (_| | ||  __/ | | | | | (_| | |_| | (_| (_| \\__ \\      ");
Console.WriteLine("|_|  |_|\\__,_|\\__\\___|_| |_| |_|\\__,_|\\__|_|\\___\\__,_|___/      ");
Console.WriteLine("                                                                ");
Console.WriteLine("                            /\\| |/\\                             ");
Console.WriteLine("                            \\ ` ' /                             ");
Console.WriteLine("                           |_     _|                            ");
Console.WriteLine("                            / , . \\                             ");
Console.WriteLine("                            \\/|_|\\/                             ");



    Thread.Sleep(3000);
     Console.Clear();
     
     
     Console.WriteLine("|  \\/  | __ _| |_ ___ _ __ ___   /_/_| |_(_) ___ __ _ ___       ");
Console.WriteLine("| |\\/| |/ _` | __/ _ \\ '_ ` _ \\ / _` | __| |/ __/ _` / __|      ");  
Console.WriteLine("| |  | | (_| | ||  __/ | | | | | (_| | |_| | (_| (_| \\__ \\      ");
Console.WriteLine("|_|  |_|\\__,_|\\__\\___|_| |_| |_|\\__,_|\\__|_|\\___\\__,_|___/      ");
Console.WriteLine("                                                                ");
Console.WriteLine("                            /\\| |/\\                             ");
Console.WriteLine("                            \\ ` ' /                             ");
Console.WriteLine("                           |_     _|                            ");
Console.WriteLine("                            / , . \\                             ");
Console.WriteLine("                            \\/|_|\\/                             ");



    Thread.Sleep (1000);
     Console.Clear();
  
  
  
  // 2 Mostrar menú de opciones
    Console.WriteLine("Menú de opciones");
    Console.WriteLine("Seleccionar la opción deseada:");
    Console.WriteLine("1. Suma");
    Console.WriteLine("2. Resta");
    Console.WriteLine("3. Multiplicación");
    Console.WriteLine("4. Divisón");
    Console.WriteLine("5. Salir");
    
    // 3 capturar opción elegida por usuario
    Console.Write("Digitar opción deseada: ");
    int opcion = Int32.Parse(Console.ReadLine());

               if (opcion ==5){
                   goto salir;
     // 3.5 capturar los números elegidos por el usuario
    Console.Write("\nDigitar numero 1: ");
    int numero1 = Int32.Parse(Console.ReadLine());
    Console.Write("\nDigitar numero 2: ");
    int numero2 = Int32.Parse(Console.ReadLine());
    
    // 4 Validar opción elegida
    if( opcion == 1){
        Console.WriteLine("La suma es: " + (numero1+numero2));
    }
    
    if( opcion == 2){
        Console.WriteLine("La resta es: " + (numero1-numero2));
    }
    
    if( opcion == 3){
        Console.WriteLine("La multiplicación es: " + (numero1*numero2));
    }
    
    if( opcion == 4){
        if ( numero1 != 0 || numero2 !=0){
            Console.WriteLine("La división es: " + (numero1/numero2));    
        }
        else{
            Console.WriteLine("No se puede dividir por cero.");    
        }
        
    }
    
    
    
    // 5 Mostrar resultado o finalizar ejecución
   salir:
      Console.WriteLine("saliendo del programa...");
      
  }
    
}
  
}
  
  
  
  
  
  
  
  
  
  
   
