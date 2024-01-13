// contexto de ejecucion para importar modulo
using System;

// clases
// Gracias a lo de la linea 8 se genera el punto de ejecucion.
class HelloWord
{
    static void Main(string[] args)
    {
        // imprime en la consola un mensaje es el primo de console.log()
        //Console.WriteLine("Hello, MILTONNN!");



        // ejemplo de usar strings y int concatenando, se puede aplicar con otras estructuras de datos
        string miSaludo = "hola, me llamo Milton";
        string texto = "soy programador";

        Console.WriteLine(miSaludo);
        Console.WriteLine(texto);

        int age = 26;
        Console.WriteLine($"tengo {age} años ");



        // estructura
        // array
        var miArayy1 = new string[]
        {
            "hamburguesas", "helado", "cocacola"


        };
        Console.WriteLine("mi comida favorita es:");
        Console.WriteLine(miArayy1[0]);
        // dictionary 
        var miInfo = new Dictionary<string, int>
        {
            {"¿cuantos perros tienes?", 3 },
            {"¿cuantos gatos tienes?", 2 }


        };
        Console.WriteLine(miInfo["¿cuantos perros tienes?"]);
        Console.WriteLine(miInfo["¿cuantos gatos tienes?"]);

    }




};



