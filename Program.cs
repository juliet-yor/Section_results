string [] array(){
Console.Write("Укажите длину массива: ");
int size = Convert.ToInt32(Console.ReadLine());
string [] array = new string[size];
int len = 3;
int pos = 0;
for (int i = 0; i < size; i++)
{
    Console.WriteLine($"Введите {i+1}-й элемент: ");
    string? element = Console.ReadLine();
    if (element?.Length <= len)
    {
        array[pos] = element;
        pos++;
    }  
}
return array;
}

PrintArray(array());

void PrintArray(string [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}