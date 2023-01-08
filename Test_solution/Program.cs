// Написать программу, которая из имеющегося массива строк формирует массив 
// из строк длина которых меньше или либо равна трем символам.
// Первоначальный массив можно ввести с клавиатуры либо задать на старте выполнения алгоритма.








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