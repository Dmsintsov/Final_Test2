int Text(string message)
{
    Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

void FillArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write("Введите элемент массива: ");
        arr[i] = Console.ReadLine();
    }

}
void PrintArray(string[] col)
{
    int count = col.Length;
    for (int position = 0; position < count; position++)
    {
        if (position < col.Length - 1) Console.Write(col[position] + ", ");
        else
        {
            Console.Write(col[position]);
        }
    }

}
int NewLengthArray(string[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length < 4) count++;

    }
    return count;
}

void FillNewArray(string[] arr1, string[] arr2)
{
    int k = 0;
    for (int i = 0; i < arr1.Length; i++)
    {
        if (arr1[i].Length < 4)
        {
            arr2[k] = arr1[i];
            k++;
        };

    }

}
int lengthArray = Text("Введите длину массива: ");
string[] array = new string[lengthArray];
FillArray(array);
Console.WriteLine();
Console.Write("[");
PrintArray(array);
Console.Write("] -> ");
string[] newArray = new string[NewLengthArray(array)];
FillNewArray (array, newArray);
Console.Write("[");
PrintArray(newArray);
Console.WriteLine("]");