internal class Program
{
  private static void Main(string[] args)
  {
    /*Ejercicio 1
    Variables Escribe un programa que reciba datos de una persona y genera un mensaje, usa una variable para cada dato y otra para el mensaje. Ej: nombre, apellido, edad, sabe programar, etc.
    */
    Console.WriteLine("Ingresa tu nombre: ");
    String nombre = Console.ReadLine();

    Console.WriteLine("Ingresa tu apellido: ");
    String apellido = Console.ReadLine();

    Console.WriteLine("Ingresa tu edad: ");
    int edad = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("¿Sabes Programar ?");
    String sabesProgramar = Console.ReadLine();

    Console.WriteLine("Hola " + nombre + " " + apellido + " tu tienes " + edad + " años." + " Tu " + sabesProgramar + " sabes programar.");

    /* Ejercicio 2 
    Tipos Usando los tipos de variables más adecuados, describe los objetos siguientes:
    -Coche: puertas, ruedas, marca, ITV vigente
    -Mesa: peso, largo, material, color
    */
    Console.WriteLine("_____________________________________________________________");
    Console.WriteLine("Descripcion de tu Coche");
    Console.WriteLine("¿Cuantas puertas tiene tu coche? ");
    int puertas = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("¿Cuantas ruedas tiene tu coche? ");
    int ruedas = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("¿Marca de tu coche? ");
    String marca = Console.ReadLine();

    Console.WriteLine("¿Tienes tu ITV vigente? ");
    String itvVigente = Console.ReadLine();

    Console.WriteLine("Tienes " + puertas + " puertas tu coche, " + "tiene " + ruedas + " ruedas, " + "la marca es " + marca + " Tu Itv esta vigente " + itvVigente + " buen vehiculo.");

    Console.WriteLine("_____________________________________________________________");
    Console.WriteLine("Descripcion de tu mesa ");
    Console.WriteLine("¿Cuanto pesa (kg)?");
    int peso = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("¿Cual es el largo (Cm)? ");
    int largo = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("¿ De que material esta fabricada? ");
    String material = Console.ReadLine();

    Console.WriteLine("¿Cual es el color? ");
    String color = Console.ReadLine();

    Console.WriteLine("Tu mesa pesa " + peso + " kg, " + "tiene un largo de " + largo + " Cm," + " esta fabricada en " + material + " y  es de color " + color);


    /*
    Ejercicio 3
    Operadores Determina los operadores para verificar las siguientes condiciones:
    -Un número es mayor o igual a 18
    -Un char es ‘a’
    -Se cumplen dos conciones a la vez (ambas verdaderas)
    -Se cumple una de dos condiciones a la vez (una true y otra false)
    */
    Console.WriteLine("Ingresa Un numero: ");
    int numero = Convert.ToInt32(Console.ReadLine());

    Boolean resultado = numero >= 18;
    Console.WriteLine("El numero es " + resultado);

    // Un char es ‘a’
    Console.WriteLine("Ingresa una letra : ");
    String palabra = Console.ReadLine();
    char? letra = null;
    Boolean esChar = palabra.Equals(letra);

    Console.WriteLine("Lo ingresado es char " + esChar);


    // Se cumplen dos conciones a la vez(ambas verdaderas)
    Console.WriteLine("Ingresa un dato: ");
    int dato = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Ingresa un dato 1: ");
    int dato1 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Ingresa un dato 2: ");
    int dato2 = Convert.ToInt32(Console.ReadLine());

    Boolean resultadoDatos = dato == dato1 && dato1 == dato2;

    Console.WriteLine("El resultado de la comparacion de los datos es " + resultadoDatos);

    // Se cumple una de dos condiciones a la vez(una true y otra false)

    Boolean resultadoDatosOr = dato == dato1 || dato1 == dato2;

    Console.WriteLine("El resultado de la comparacion de los datos es: " + resultadoDatosOr);

    

  }
}



