string [] array = new string[] { "top", " my", "pi", "cook", "tip", "Hello", "content" };
int maxLenght = 3;

int newSize = 0;
for (int i = 0; i < array.Length; i++)
{
    if(array[i].Length <= maxLenght)
    {
        newSize++;
    }

}
string [] newArray = new string[newSize];
Console.WriteLine("New Size = " + newSize);
int j = 0;
for ( int i = 0; i < array.Length; i++)
{
    if(array[i].Length <= maxLenght)
    {
        newArray[j] = array[i];
        j++;
    }
}

for (int i = 0; i < array.Length; i++)
{
    Console.Write($"{newArray[i]}, ");
}
