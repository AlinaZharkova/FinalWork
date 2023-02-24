// Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых либо меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма.
// При решение не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

Console.WriteLine("Выберите количество строк в массиве:");
int N = Convert.ToInt32(Console.ReadLine());
string[] sourceArray = new string[N]; //вводим начальный массив из N строк (вручную построчно)
for (int i = 0; i < N; i++)
{
    Console.WriteLine($"Задайте строку {i + 1}: ");
    string element = Console.ReadLine()!;
    sourceArray[i] = element;
}

void PrintArray(string[] array) //метод для распечатки(вывода) одномерного массива
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}  ");
    }
    Console.WriteLine();
}

string[] resultArray = new string[N]; //заполняем новый массив строками из начального массива (длина строки <=3)
int count = 0;
for (int i = 0; i < N; i++)
{
    if (sourceArray[i].Length <= 3)
    {
        resultArray[count] = sourceArray[i];
        count++;
    }
}

Console.WriteLine();
PrintArray(resultArray);
