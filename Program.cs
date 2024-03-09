
int CountArraySize(string[] Array1)
{
    int size = 0;
    foreach (string element in Array1)
        if (element.Length <= 3) size++;
    return size;
}

string[] MakeNewArray(string[] Array1, int arraySize)
{
    int i = 0;
    string[] newArray = new string[arraySize];
    foreach (string element in Array1)
    {
        if (element.Length <= 3)
        {
            newArray[i] = element;
            i++;
        }
    }
    return newArray;
}

void PrString(string[] chars)
{
    if (chars.Length == 0)
        System.Console.Write("[]");

    else
    {
        char sim = '"';
        Console.WriteLine($"[{sim}{string.Join($"{sim}, {sim}", chars)}{sim}]");
    }
}
string[] Array1 = { "rkg", "RFJTF", ";-)", "123" };
int arraySize = CountArraySize(Array1);
string[] newArray = MakeNewArray(Array1, arraySize);
PrString(newArray);
