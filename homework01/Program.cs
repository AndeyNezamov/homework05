int[] CreateRandomArray(int size)
{
    int[] array = new int[size];
    for(int i=0; i<size; i++)
    {
        array[i]=new Random().Next(100, 1000);
    }
    return array;
}

void ShowArray(int[] array)
{
    for(int i=0; i<array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

int evenArray(int[] array)
{
    int count = 0;
    for(int i=0; i<array.Length; i++)
        if(array[i]%2 == 0)
            count++;
    return count;
}

Console.Write("Input a lengt of new array: ");
int lengt = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateRandomArray(lengt);
ShowArray(myArray);
int result = evenArray(myArray);
Console.WriteLine(result);