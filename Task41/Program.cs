// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3

int getUserData(string message)
{
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine(message);
    Console.ResetColor();
    int userData = int.Parse (Console.ReadLine()!);
    return userData;
}


int[] createArray(int lenght)
{
    int[] result = new int[lenght];
    for (int i=0; i< lenght; i++)
    {
        result[i]= int.Parse(Console.ReadLine());
    }
    return result;
}


int CountPositiveNumber(int[] arr)
{
    int count = 0;
    for (int i=0; i< arr.Length; i++)
    {
        if (arr[i]>0) count = count + 1;
    }
    return count;
}

void showArray(int[] array)
{
    
    for (int i=0; i<array.Length; i++)
    {
        if (i !=array.Length -1)
        {
            Console.Write($"{array[i]}, ");
        }
        else
        {
            Console.Write($"{array[i]}");
        }
    }
}

int lenght = getUserData("Введите количество чисел");
int[] array = createArray(lenght);
int result = CountPositiveNumber(array);

showArray(array);
Console.WriteLine($"  -> положительных из них: {result}");