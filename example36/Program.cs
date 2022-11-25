/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

int[] GetFillArray(int arrayLen, int arrMin, int arrMax)
{
    int [] resultArray = new int [arrayLen];
    Random rnd = new Random();
    for (int i=0; i<resultArray.Length; i++)
        resultArray[i] = rnd.Next(arrMin, arrMax);
    return resultArray;
}

int GetNotHonest (int[]arg)
{
    int result = 0;
    for (int i=1; i<arg.Length; i+=2)
        result = result+ arg[i];
    return result;
}

Console.WriteLine("Введите размер массива");
int arrayLenght = int.Parse(Console.ReadLine());
int [] array = GetFillArray(arrayLenght,-99,100);
Console.WriteLine(String.Join(", ", array));
Console.WriteLine("-> "+GetNotHonest(array));
