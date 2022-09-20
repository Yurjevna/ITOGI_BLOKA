string text = "12354, hello, war, no";
string p = text.Replace(" ", "");
string[] words = p.Split(',');
for (int i = 0; i < words.Length; i++)
{
    Console.WriteLine(words[i] + "\t" + words[i].Length);
}
Console.WriteLine();

string[] words1 = new string[words.Length];

void FillArr(string[] array, string[] array1)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            array1[count] = array[i];
            count++;
        }
    }
}

void PrintArr(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + "\t");
    }
}

FillArr(words, words1);
PrintArr(words1);
