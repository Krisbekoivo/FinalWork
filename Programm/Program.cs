string[] CreateArray(int m)
{
    string[] array = new string[m];
    Console.WriteLine("Введите элементы массива ");
    for (int i = 0; i < m; i++)
        array[i] = Console.ReadLine();
    return array;
}

int CountStr(string[] array) 
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) count++;
    }
    return count;
}

string[] FilterArray(string[] array, int count)
{
    string[] result = new string[count];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            result[result.Length - count] = array[i];
            count--;
        }
    }
    return result;
}

void ShowArray(string[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
        if (i == (array.Length - 1))
        {
            Console.Write(array[i] + " ");
        }
        else
        {
            Console.Write(array[i] + ", ");

        }
    Console.WriteLine("]");
}
Console.Write("Введите число элементов массива ");
int s = Convert.ToInt32(Console.ReadLine());
string[] newArray = CreateArray(s);
int count = CountStr(newArray);
string[] resultFirst =  FilterArray(newArray,count);
ShowArray(resultFirst);