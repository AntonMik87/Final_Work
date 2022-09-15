Console.Clear();
string[] array = new string[] { "123", "sring", "1", "For", "1234", "%", "//" };
for (int i = 0; i < array.Length; i++)
{
    Console.Write($"{array[i]} ");
}

Console.WriteLine();
Console.Write("Результат: ");

for (int i = 0; i < array.Length; i++)
{
    string arr = array[i];
    if (arr.Length <= 3)
    {
        Console.Write($"{array[i]} ");

    }

}