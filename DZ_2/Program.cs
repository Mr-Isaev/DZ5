/* Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */

int[] CreateRandomArray(int N, int start, int end)
{
    int[] RandomArray = new int[N];
    for (int i = 0; i < N; i++)
    {
        RandomArray[i] = new Random().Next(start, end + 1);
    }
    return RandomArray;
}
void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

void ArraysUnevenPosNumbs(int[] array)
{
    int sum = 0;
    Console.Write("Числа на нечётных позициях: ");
    for (int i = 1; i < array.Length; i += 2)
    {
        Console.Write($"{array[i]}; ");
        sum += array[i];
    }
    Console.WriteLine();
    Console.WriteLine($"Сумма чисел стоящих на нечетных позициях: {sum}");
}
int[] array = CreateRandomArray(8, 100, 1000);
ArraysUnevenPosNumbs(array);
Console.Write("Ваш массив: ");
ShowArray(array); 