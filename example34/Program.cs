/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/

int[] GetFillArray(int arrayLen, int arrMin, int arrMax)
{
    int [] resultArray = new int [arrayLen];
    Random rnd = new Random();
    for (int i=0; i<resultArray.Length; i++)
        resultArray[i] = rnd.Next(arrMin, arrMax);
    return resultArray;
}

int GetHonestCount (int[]arg)
{
    int result = 0;
    for (int i=0; i<arg.Length; i++)
        if  (arg[i] % 2 == 0)  result++;
    return result;
}

Console.WriteLine("Введите размер массива");
int arrayLenght = int.Parse(Console.ReadLine());
int [] array = GetFillArray(arrayLenght,100,1000);
Console.WriteLine(String.Join(", ", array));
Console.WriteLine("-> "+GetHonestCount(array));
