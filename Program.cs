

int[] CreateRandomeArray(int size, int minValue, int maxValuse)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValuse + 1);
    }
    return array;
}

string[] CreateNewArray(int size)
{
    string[] array = new string[size];
    System.Console.WriteLine("Enter a new array");
    for (int i = 0; i < size; i++)
    {
        array[i] = Console.ReadLine();
    }
    return array;
}

string[] Find(string array[])
{
    string[] new_array = new string[size];
    int j = 0;
    for (int i = 0; i < size; i++)
    {
        if (array[i].Length <= 3)
        {
            new_array[j]=array[i];
        }
    }
}



