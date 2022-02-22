using System;

class Casilla
{
    int x;                                              //declaracion de atributos
    int y;
    ConsoleColor color;

    public void Posicionar(int nuevaX, int nuevaY)      //metodo para ubicar el cursor
    {
        x = nuevaX;
        y = nuevaY;

        Console.SetCursorPosition(x, y);
    }

    public void ColorCasilla(ConsoleColor nuevoColor)     //metodo para colorear las casillas
    {
        color = nuevoColor;
        Console.BackgroundColor = color;
        Console.ForegroundColor = color;   
    }
}