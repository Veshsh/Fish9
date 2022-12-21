using System.Diagnostics.Metrics;
using System.Reflection;

namespace Fish9
{
    internal class Fish9
    {
        public static int longer = 5;
        static void Main()
        {
            
            int counter = 0;
            bool condition= true;
            const int maxnumberofrabbits = 1;
            int numberofrabbits=0;
            Field.zero();//не получилось в конструкторе
            Field.borders();
            Field.graphicfiled();//рисуем рисуем рисуем ...
            Field.graphicscore();//рисуем рисуем рисуем ...
            Console.ReadKey();
            while (condition)
            {
                if (counter > longer+1)
                    Snake.tail();//обрезаем питона 
                else
                    counter++;
                numberofrabbits = Snake.snakeeat(numberofrabbits);//питона не трогать он жрёт
                condition = Snake.snakego();
                Field.snakego();//рисуем рисуем рисуем ...
                Field.Clear();//это не Console.Clear(); не путать
                Snake.directione();// считываем клавиши
                Thread.Sleep(100);//не будите дайте поспать
                if (numberofrabbits < maxnumberofrabbits)//создавать кролика или не создават, вот в чём вопрос!?
                {
                    Field.rabit();//это не яблоки это кролики
                    numberofrabbits++;//Писал Егор(нет, этояблокиеблан)
                } 
                Field.graphicrabit();//рисуем рисуем рисуем ...

            }
            Console.Clear();//Моим экран
            Console.WriteLine("Game Over");// ИГРА ОКОНЧЕНА!!!
        }
    }
}
