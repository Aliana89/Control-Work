/*
Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться 
коллекциями, лучше обойтись исключительно массивами*/

// Создаем исходный массив из строк
string[] strings = new string[] { "1234", "1567", "-2", "computer science"};
// Вызываем метод для формирования нового массива
string[] newStrings = NewArrayLessOrEqualToThreeChars(strings);
//Печатаем исходный массив 
Console.Write("[");
Console.Write(string.Join("," ,strings));
Console.Write("]");
Console.Write("->");
//Печатаем новый массив
Console.Write("[");
Console.Write(string.Join($"{","}",newStrings));
Console.Write("]");

string[] NewArrayLessOrEqualToThreeChars(string[] strings)
{

    int count = 0;
    int i = 0;
    while (i < strings.Length)
    {
        if (strings[i].Length <= 3)
        {
            count++;
        }
        i++;
    }

    
    string[] newStrings = new string[count];

   
    int index = 0;
    int j = 0;
    while (j < strings.Length)
    {
        if (strings[j].Length <= 3)
        {
            newStrings[index] = strings[j];
            index++;
        }
        j++;
    }

    return newStrings;
}
