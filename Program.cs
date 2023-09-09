

using System.ComponentModel;

string[] CreateRandomeArray(int size, int minValue, int maxValuse)
{
    string[] array = new string[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = Convert.ToString(new Random().Next(minValue, maxValuse + 1));
    }
    return array;
}

string[] CreateNewArray(int size)
{
    string[] array = new string[size];
    System.Console.WriteLine("Enter a new array");
    for (int i = 0; i < size; i++)
    {
        array[i] = Convert.ToString(Console.ReadLine());
    }
    return array;
}

string[] Find(string[] array)
{
    string[] new_array = new string[array.Length];
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            new_array[j] = array[i];
            j++;
        }
    }
    return new_array;
}


System.Console.WriteLine("set the array by yourself (yes or no)");
string a = Convert.ToString(Console.ReadLine());

if (a == "yes")
{
    System.Console.WriteLine("enter array size");
    int size = Convert.ToInt32(Console.ReadLine());
    System.Console.WriteLine(String.Join(", ", Find(CreateNewArray(size))));

}
if (a == "no")
{
    System.Console.WriteLine("enter array size");
    int size = Convert.ToInt32(Console.ReadLine());
    System.Console.WriteLine("enter min value");
    int minValue = Convert.ToInt32(Console.ReadLine());
    System.Console.WriteLine("enter max value");
    int maxValuse = Convert.ToInt32(Console.ReadLine());
    System.Console.WriteLine(String.Join(", ", Find(CreateRandomeArray(size, minValue, maxValuse))));
}
