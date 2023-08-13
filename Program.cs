string[] CreateNewArray(int size)
{
    string[] array = new string[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = Console.ReadLine();
    }
    return array;
}

