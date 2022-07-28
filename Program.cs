string[] specifiedArray = new string[7] {"let", "me", "go", "hello", "world", "404", ":-)"};
string[] finalArray = new string[specifiedArray.Length];

void ArrayСonversion(string[] specifiedArray, string[] finalArray)
{
    int count = 0;
    for (int i = 0; i < specifiedArray.Length; i++)
    {
    if(specifiedArray[i].Length <= 3)
        {
        finalArray[count] = specifiedArray[i];
        count++;
        }
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

ArrayСonversion(specifiedArray, finalArray);
PrintArray(finalArray);
