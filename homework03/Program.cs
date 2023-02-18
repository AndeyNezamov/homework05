//Задайте массив вещественных чисел. Найдите разницу между максимальным 
//и минимальным элементов массива

double[] RandomArray(int size, int minValue, int maxValue)
{
    double[] array = new double[size];
    for(int i=0; i<size; i++)
    {
        array[i]=new Random().Next(minValue, maxValue+1);
        array[i] += new Random().NextDouble();
    }
    return array;
}

void ShowArray(double[] array)
{
    for(int i=0; i<array.Length; i++)
        Console.Write(Math.Round(array[i], 2) + " ");
    Console.WriteLine();
}

double MinMax(double[] array)
{
    double min = array[0];
    double max = array[0];
    double result = 0;
    for(int i=0; i<array.Length; i++)
        if(min>array[i])
            min = array[i];
    for(int i=0; i<array.Length; i++)
        if(max<array[i])
            max= array[i];
    result = max - min;
    return result;
}

Console.Write("Input size: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max: ");
int max = Convert.ToInt32(Console.ReadLine());
double[] myArray = RandomArray(size, min, max);
ShowArray(myArray);
double result = MinMax(myArray);
Console.WriteLine(Math.Round(result, 2));