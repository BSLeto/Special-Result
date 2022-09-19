Console.Clear();
string[] start_array = new string[8] { "red", "blue", "world", "player", "settings", "qwe", "yas", "mod" };
string[] final_array = new string[start_array.Length];
int count = 0;
for (int i = 0; i < start_array.Length; i++)
{
    if (start_array[i].Length <= 3)
    {
        final_array[count] = start_array[i];
        count++;
    }
}
Console.WriteLine($"Start Array: {String.Join(" ", start_array)}");
Console.WriteLine($"Final Array: {String.Join(" ", final_array)}");
