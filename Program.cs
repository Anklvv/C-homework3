#pragma warning disable
//  19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.


Console.WriteLine ("Введите 5-ти значное число: ");
string number = Console.ReadLine();
int len = number.Length;

if (len == 5)
{
    if (number[0] == number[4] && number [1] == number[3])
    {
        Console.WriteLine(number + " Палиндром");
    }

    else
    {
        Console.WriteLine(number + " Не палиндром");
    }
}
else
{
    Console.WriteLine ("Вы ввели НЕ 5-и значное число");
}


// 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

int n;
Console.WriteLine($"Введите N: ");
int.TryParse(Console.ReadLine()!, out n);

for (int i = 1; i <= n; i++)
{
    Console.Write($"{i*i*i} ");
}



// 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

int x1, x2, y1, y2, z1, z2;

Console.Write($"Введите x1: ");
int.TryParse(Console.ReadLine(), out x1);
Console.Write($"Введите y1: ");
int.TryParse(Console.ReadLine(), out y1);
Console.Write($"Введите z1: ");
int.TryParse(Console.ReadLine(), out z1);
Console.Write($"Введите x2: ");
int.TryParse(Console.ReadLine(), out x2);
Console.Write($"Введите y2: ");
int.TryParse(Console.ReadLine(), out y2);
Console.Write($"Введите z2: ");
int.TryParse(Console.ReadLine(), out z2);

int A = x2 - x1;
int B = y2 - y1;
int C = z2 - z1;

double length = Math.Sqrt(A * A + B * B + C * C);
Console.WriteLine("Расстояние = " + length);
