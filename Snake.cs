using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Fish9;
internal class Snake
{
    public int width;
    public int height;
    public static int xposition = 1;
    public static int yposition = 1;
    public static int direction = 1;
    public static int score = 0;
    public static List<Snake> xyposition = new List<Snake>();
    public static bool snakego()
    {
        if (Field.field[yposition, xposition].tupe == 1)
            return false;
        else
        {
            snakegoo();
            return true;
        }
    }
    private static void snakegoo()
    {
        Snake position = new Snake();
        Field cell = new Field();
        cell.name = '+';
        cell.tupe = 1;
        Field.field[yposition, xposition] = cell;
        position.width = xposition;
        position.height = yposition;
        xyposition.Add(position);
    }
    public static int snakeeat(int numberofrabbits)
    {
        if (Field.field[yposition, xposition].tupe == 2)
        {
            Fish9.longer++;
            score += 10;
            Field.graphicscore();
            return numberofrabbits - 1;
        }
        else
            return numberofrabbits;
    }
    public static void tail()
    {
        Field cell = new Field();
        cell.name = ' ';
        cell.tupe = 0;
        Field.field[xyposition[0].height, xyposition[0].width] = cell;
        xyposition.RemoveAt(0);
    }
    public static void directione()
    {
        key();
        switch (direction)
        {
            case 1:
                if (xposition >= (int)Borders.maxborders-1)
                    xposition = 0;
                else
                    xposition++;
                break;
            case 2:
                if (xposition <= 0)
                    xposition = (int)Borders.maxborders-1;
                else
                    xposition--;
                break;
            case 3:
                if (yposition >= (int)Borders.maxborders-1)
                    yposition = 0;
                else
                    yposition++;
                break;
            case 4:
                if (yposition <= 0)
                    yposition = (int)Borders.maxborders-1;
                else
                    yposition--;
                break;
        }
    }
    private static void key()
    {
        if (Console.KeyAvailable == true)
            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.RightArrow:
                case ConsoleKey.D:
                    if (direction != 2)
                        direction = 1;
                    break;
                case ConsoleKey.LeftArrow:
                case ConsoleKey.A:
                    if (direction != 1)
                        direction = 2;
                    break;
                case ConsoleKey.DownArrow:
                case ConsoleKey.S:
                    if (direction != 4)
                        direction = 3;
                    break;
                case ConsoleKey.UpArrow:
                case ConsoleKey.W:
                    if (direction != 3)
                        direction = 4;
                    break;
            }
    }
}