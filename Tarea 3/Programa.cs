using System;

class Programa
{
    static void Main()
    {
        Console.Title = ("Tarea 3");

        int x;                                  //variables de posicion
        int y;
        string linea;                           // string para leer las cordenadas ingresadas por el usuario;
        Casilla c1 = new Casilla();             //objeto de tipo Casilla

        Console.WriteLine("ingrese una coordenada en x"); 
        linea = Console.ReadLine();
        x = int.Parse(linea);

        Console.WriteLine("ingrese una coordenada en y");
        linea = Console.ReadLine();
        y = int.Parse(linea);

        c1.Posicionar(x, y);                    //se ubica la casilla de las coordenadas ingresadas

        
        // creacion de la bandera

        for (int i = 0; i <= 8; i++)
        {
            if (i < 3 || i > 5)                                             //para las franjas azules
            {                                                               //lineas 1,2,3,7,8,9
                c1.ColorCasilla(ConsoleColor.DarkCyan);
                c1.Posicionar(x, y + i);
                Console.WriteLine("* * * * * * * * * * * * * * * * *"); 
            }

            else                                                           //para la franja blanca
            {                                                              
                if (i == 3 || i == 5)                                      //lineas 4,6
                {                                                          
                    c1.Posicionar(x, y + i);                                
                    c1.ColorCasilla(ConsoleColor.White);
                    Console.Write("* * * * * * * ");
                    c1.ColorCasilla(ConsoleColor.Yellow);
                    Console.Write("* * *");
                    c1.ColorCasilla(ConsoleColor.White);
                    Console.WriteLine("* * * * * * * ");
                }
                else                                                        //linea 5
                {
                    c1.ColorCasilla(ConsoleColor.White);
                    c1.Posicionar(x, y + i);                                
                    Console.Write("* * * * * * *");
                    c1.ColorCasilla(ConsoleColor.Yellow);
                    Console.Write("* * * *");
                    c1.ColorCasilla(ConsoleColor.White);
                    Console.WriteLine("* * * * * * *");
                }
            }
        }
        Console.ReadLine();
    }
}