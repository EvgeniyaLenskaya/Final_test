string[] firstArray = new string[9] {"Say", "hi", "Hello ", "to", "world ","a", "new", "day", ")"};
string[] secondArray = new string[firstArray.Length];
int secondArrayIndex = 0;

string[] resultArray = FillResultArray(firstArray, secondArray);
string[] FillResultArray(string[] firstArray, string[] secondArray)
{
    for (int i = 0; i < firstArray.Length; i++)
    {
        if(firstArray[i].Length <=3)
        {
            secondArray[secondArrayIndex] = firstArray[i];
            secondArrayIndex++;
        }
    }
    return secondArray;
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine(); 
}
Console.WriteLine();
PrintArray(firstArray);
Console.WriteLine();
PrintArray(secondArray);
