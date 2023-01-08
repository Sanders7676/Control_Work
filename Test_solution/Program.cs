﻿// Написать программу, которая из имеющегося массива строк формирует массив 
// из строк длина которых меньше или либо равна трем символам.
// Первоначальный массив можно ввести с клавиатуры либо задать на старте выполнения алгоритма.




// Метод формирования и заполнения массива элементами заданного размера

string[] FillingArrayWithGivenElementSize(string[] arrayFirst, int limitingValue)
{
    // Находим какой будет длина искомого массива

    int lengthOfSecondArray = 0;

    string elementValue = string.Empty;

    for (int i = 0; i < arrayFirst.Length; i++)
    {
        elementValue = arrayFirst[i];

        if (elementValue.Length <= limitingValue)
        {
            lengthOfSecondArray++;
        }
    }

    // Заполняем искомый массив элементами в соответствии с установленным ограничением

    string[] arraySecond = new string[lengthOfSecondArray];

    int iSecond = 0;

    for (int i = 0; i < arrayFirst.Length; i++)
    {
        elementValue = arrayFirst[i];

        if (elementValue.Length <= limitingValue)
        {
            arraySecond[iSecond] = arrayFirst[i];

            iSecond++;
        }
    }
    return arraySecond;
}






// Метод для приема чисел, вводимых через консоль

int InputInt()
{
    bool isNum = int.TryParse(Console.ReadLine(), out int num);

    if (isNum)
    {
        return num;
    }
    else
    {
        Console.WriteLine("Введено некорректное значение.");
        return -1;
    }
}



// Метод заполнения массива значениями, вводимыми через консоль

string[] FillArray(string[] arr)
{
    Console.WriteLine();

    Console.WriteLine("Введите символьные значения элементов массива:");

    Console.WriteLine();

    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"Введите значение {i + 1}-го элемента: ");

        arr[i] = Console.ReadLine();
    }
    return arr;
}



//Метод печати массива

void PrintArray(string[] array)
{
    Console.WriteLine($"[ {string.Join(", ", array)} ]");
}