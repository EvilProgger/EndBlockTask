// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
// лучше обойтись исключительно массивами.

Console.Clear();
// Массив задан на старте
string[] array = { "58", "middle", "LoL", "12345",
      "item", "qwe", "maim", "-_-" };

Console.WriteLine("Первоначальный массив:");
WriteArray(array);

// Создание результирующего массива 
string[] result = new string[CountSize(array)];

// заполнение результирующего массива
int i=0;
int n=0;
while (i<array.Length)
    {
        if (size(array[i]))
        {
            result[n]=array[i];
            n++;
        
        }
            i++;
    }
Console.WriteLine("Результирующий массив: ");
WriteArray(result);

// Вывод массива
void WriteArray(string[] array)
    {
        int i=0;
        while (i<array.Length)
        {
            Console.Write($" {array[i]}");
            i++;
        }
        Console.WriteLine();
    }

// Сколько у нас элементов для массива с результатами
int CountSize(string[] array)
{
    int n=0;
    int i=0;
    while (i<array.Length)
    {
        if (size(array[i])) n++;
            
        i++;
    }
    return n;
}

// Проверка длины элемента строки
bool size(string s) 
{
    if (s.Length<4) 
    return true;
    else return false;
}