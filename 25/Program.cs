// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int GetSqr(int a, int b){
    int sqr = 1;
    for (int i = 0; i < b; i++) {

        sqr *= a;
    }
    return sqr;
}

Console.Clear();
Console.WriteLine("Введите число a");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число b");
int b = int.Parse(Console.ReadLine());
Console.WriteLine($"{a} в степени {b} равно {GetSqr(a, b)}");