// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

int getUserData(string message)
{
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine(message);
    Console.ResetColor();
    int userData = int.Parse (Console.ReadLine()!);
    return userData;
}

double getPointX(int k1, int b1, int k2, int b2)
{
    if (k1==k2)
    {
        return -1;
    }
    else 
    {
        double x = (double)(b2-b1)/(k1-k2);
        return x;
    }
}

double getPointY(int k1, int b1, int k2, int b2)
{
     if (k1==k2)
    {
        return -1;
    }
    else 
    {
        double x = (double)(b2-b1)/(k1-k2);
        double y= k2*x + b2;
        return y;
    }
}

int k1 = getUserData("Введите k1");
int b1 = getUserData("Введите b1");
int k2 = getUserData("Введите k2");
int b2 = getUserData("Введите b2");

double point_X = getPointX(k1, b1, k2, b2);
double point_Y = getPointY(k1, b1, k2, b2);

if (k1==k2) Console.WriteLine($"Нет точки пересечения прямых, прямые параллельны");
else Console.WriteLine($"Точка пересечения прямых:({point_X}; {point_Y})");
