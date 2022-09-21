Console.Clear();
Console.Write("Ведите число элементов: ");
int size = int.Parse(Console.ReadLine());

string[] Array = new string[size];
for (int p = 0; p < size; p++)
{
    Console.WriteLine($"Введите {p+1} элемент: ");
    string element = Convert.ToString(Console.ReadLine());
    Array[p] = element;
}

string[] FinalArray = new string[size];
int i = 3;
int j = 0;

for (int k = 0; k < size; k++)
{
    if (Array[k].Length <= i)
    {
        FinalArray[j] = Array[k];
        j++;
    }
}

Console.WriteLine();
PrintArray(FinalArray);

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
