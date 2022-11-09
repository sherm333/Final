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
