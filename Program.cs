string[] FirstArray;
Console.WriteLine("Введите значение строк массива через пробел:");
string? inputStrings = Console.ReadLine();
FirstArray = inputStrings!.Split(' ');

string[] SecondArray = new string[FirstArray.Length];

void FillSecondArray(string[] FirstArray, string[] SecondArray)
{
    int i = 0;
    for (int j = 0; j < FirstArray.Length; j++)
    {
        if (FirstArray[j].Length <= 3)
        {
            SecondArray[i] = FirstArray[j];
            i++;
        }
    }
}

void PrintArray(string[] array)
{
    Console.WriteLine("Массив из строк, длина которых меньше либо равна трём символам:");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

FillSecondArray(FirstArray, SecondArray);
PrintArray(SecondArray);