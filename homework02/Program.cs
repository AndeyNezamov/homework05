// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

int[] RandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for(int i = 0; i<size; i++)
        array[i] = new Random().Next(minValue,maxValue+1);
    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i<array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

int SumEvenPosition(int[] array)
{
    int sum=0;
    for(int i=0; i<array.Length; i++)
        if(i%2 != 0)
            sum += array[i];
    return sum;

}

Console.Write("Input size: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max: ");
int max = Convert.ToInt32(Console.ReadLine());
int[] myArray = RandomArray(size, min, max);
ShowArray(myArray);
int result = SumEvenPosition(myArray);
Console.WriteLine(result);