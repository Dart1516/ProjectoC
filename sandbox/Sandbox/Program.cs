using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World!");
        Console.WriteLine("se imprimirá?!");
        Console.WriteLine("no apareecen loc somentaros!");
        Console.WriteLine("¡¡¡Si funciona!!!");
         int x = 5;
        Console.WriteLine("mi primer numero es: " + x);

         Console.WriteLine("git status                                       = para ver los cambios");
        Console.WriteLine("git add direccion del archivo                    = para guardar los cambios");
        Console.WriteLine("git add .                                        = para guardar los cambios");
        Console.WriteLine("git commit -m  (más comentarios entre comillas)  = para agregar um comentario");
        Console.WriteLine("git restore <file>...                            = para deshacer todos los cambios");
        Console.WriteLine("git push                                         = para enviarlos todos los cambios a git hub");

        Console.Write("What is your favorite color? ");
        string color = Console.ReadLine();
        Console.WriteLine($"yoour favorite color is:  {color}.");
        
        
        string school = "BYU-Idaho";
        Console.WriteLine($"I am studying at {school}.");


        int y = 10;

    if (x > y)
        {
        Console.WriteLine("greater");
        }

    }
    
}

