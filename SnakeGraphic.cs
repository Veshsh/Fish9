using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fish9;
internal class SnakeGraphic
{
    static SnakeGraphic()
    {
        Console.CursorVisible = false;
    }
    public static void graphicfiled()
    {
        for (int i = 0; i < (int)Borders.maxborders; i++)
        {
            for (int l = 0; l<(int)Borders.maxborders; l++)
            {
                Console.Write(Field.field[i,l].name);
                Console.Write(" ");
            }
            Console.WriteLine();
        }
    }
    public static void snakego()
    {
        for (int i = 0; i < Snake.xyposition.Count; i++)
        {
            Console.SetCursorPosition(Snake.xyposition[i].width*2, Snake.xyposition[i].height);
            Console.Write(Field.field[Snake.xyposition[Snake.xyposition.Count-1].height, Snake.xyposition[Snake.xyposition.Count-1].width].name);
        }
    }
    public static void Clear()
    {
        Console.SetCursorPosition(Snake.xyposition[0].width * 2, Snake.xyposition[0].height);
        Console.Write(' ');
    }
    public static void graphicrabit()
    {
        Console.SetCursorPosition(Field.yrabit*2, Field.xrabit);
        Console.Write('#');
    }
    public static void graphicscore()
    {
        Console.SetCursorPosition((int)Borders.maxborders * 2, 0);
        Console.Write("Score: ");
        Console.SetCursorPosition((int)Borders.maxborders * 2, 1);
        Console.Write(Snake.score);
    }
}
