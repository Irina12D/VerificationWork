
string [] CreateArray(int n)
{
    string [] Arr = new string [n];
    for(int i=0; i < n; i++)
        Arr[i] = Console.ReadLine();
    return Arr;    
}

void PrintArray(string [] mas)
{
    int n = mas.Length;
    for(int i=0;i<n;i++)
        Console.WriteLine(mas[i]);
}

string [] CreateTruncatedArray(string [] mas)
{
    int n = mas.Length;
    string [] NewArr = new string[n];
    int k = 0;
    for(int i=0; i < n; i++)
        if(mas[i].Length <=3)
            NewArr[k++] = mas[i];
    System.Array.Resize(ref NewArr, k);
    return NewArr;        
}

Console.Write("Введите количество строк исходного массива ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Вводите элементы исходного массива по одному в строке");
string [] Array = CreateArray(n);
Console.WriteLine();

Console.WriteLine("Исходный массив:");
PrintArray(Array);
Console.WriteLine();

Console.WriteLine("Сформированный массив:");
string [] ResultArr = CreateTruncatedArray(Array);
PrintArray(ResultArr);
