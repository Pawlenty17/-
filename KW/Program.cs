// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, 
// либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []


// Ввод исходного массива

Console.WriteLine("Введите исходный массив строк, разделяя их пробелами: ");
string[] inputArr = Console.ReadLine().Split(' ');

// Создание нового массива для строк длиной не более 3 символов

string[] filteredArr = new string[inputArr.Length];
int filteredArrIndex = 0;

// Фильтрация строк

foreach (string str in inputArr)
{
    if (str.Length <= 3)
    {
        filteredArr[filteredArrIndex] = str;
        filteredArrIndex++;
    }
}

// Вывод отфильтрованного массива

 Console.WriteLine("Отфильтрованный массив:");
foreach (string str in filteredArr)
{
    if (str != null)
    {
        Console.Write(str + " ");
    }
}