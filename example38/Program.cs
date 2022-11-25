/*
Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/

// Т.к. в условиях задания числа вещественные, то тип элементов массива - double

double[] GetFillArray(int arrayLen, int arrMin, int arrMax)
{
    double [] resultArray = new double [arrayLen];
    Random rnd = new Random();
    for (int i=0; i<resultArray.Length; i++)
        resultArray[i] = rnd.Next(arrMin, arrMax);
    return resultArray;
}

double FindMax (double[]arg)
{
    double result = arg[0];
    for (int i=1; i<arg.Length; i++)
        if  (arg[i] > result)  result=arg[i];
    return result;
}

double FindMin (double[]arg)
{
    double result = arg[0];
    for (int i=1; i<arg.Length; i++)
        if  (arg[i] < result)  result=arg[i];
    return result;
}

Console.WriteLine("Введите размер массива");
int arrayLenght = int.Parse(Console.ReadLine());
double [] array = GetFillArray(arrayLenght,-99, 100);  //диапазон задан условно для удобства проверки
Console.WriteLine(String.Join(", ", array));
Console.WriteLine("-> "+(FindMax(array)-FindMin(array)));