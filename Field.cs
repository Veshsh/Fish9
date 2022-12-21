using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fish9;

internal class Field : SnakeGraphic
{
    public char name;
    public int tupe;
    public static Field[,] field = new Field[(int)Borders.maxborders, (int)Borders.maxborders];
    public static int yrabit;
    public static int xrabit;
    public Field()
    {
        name = ' ';
        tupe = 0;
/*
0-пустая клетка
1-препядствие
2-яблоко
*/
    }
    public static void zero()
    {
    Field cell = new Field();
        for (int i = 0; i< (int)Borders.maxborders; i++)
            for (int l = 0; l< (int)Borders.maxborders; l++)
                field[i, l] = cell;
    }
    public static void borders()
    {
        Field cell = new Field();
        cell.name = '*';
        cell.tupe = 1;
        for (int i = 0; i < (int)Borders.maxborders; i++)
            field[0, i] = cell;
        for (int i = 0; i < (int)Borders.maxborders; i++)
            field[i, 0] = cell;
        for (int i = 0; i < (int)Borders.maxborders; i++)
            field[(int)Borders.maxborders-1, i] = cell;
        for (int i = 0; i < (int)Borders.maxborders; i++)
            field[i, (int)Borders.maxborders-1] = cell;
    }
    public static void rabit()
    {
        do
        {
            Random rnd = new Random();
            yrabit = rnd.Next(1, (int)Borders.maxborders - 1);
            xrabit = rnd.Next(1, (int)Borders.maxborders - 1);
        }
        while (field[xrabit, yrabit].tupe==1);
            Field cell = new Field();
            cell.name = '#';
            cell.tupe = 2;
            field[xrabit, yrabit] = cell;
    }
}

