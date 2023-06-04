// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] GetArr(int len){

    int[] arr = new int[len];

    for (int i = 0; i < len; i++){
        arr[i] = new Random().Next(10);
    }

    return arr;
}


Console.WriteLine("Введите размер массива");
int len = int.Parse(Console.ReadLine());
int[] result = GetArr(len);
Console.WriteLine($"Ваш массив [{String.Join(", ", result)}]");