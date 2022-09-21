Console.Clear();
string[] startArray = new string[8] { "red", "bl", "world", "player", "settings", "qwe", "yas", "mod" };
string[] finalArray = new string[startArray.Length];

void NewArray(string[] firstArray, string[] secondArray)
{
    int count = 0;
    for (int i = 0; i < firstArray.Length; i++)
    {
        if (firstArray[i].Length <= 3)
        {
            secondArray[count] = firstArray[i];
            count++;
        }
    }
}

void PrintArray(string[] array){
    Console.WriteLine($"Array : {String.Join(" ", array)}");
}
NewArray(startArray,finalArray);
PrintArray(startArray);
PrintArray(finalArray);
