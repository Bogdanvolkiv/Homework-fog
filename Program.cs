﻿string [] array = new string[] { "top", " my", "pi", "cook", "tip", "Hello", "content" };
int maxLenght = 3;

int newSize = 0;
for (int i = 0; i < array.Length; i++)
{
    if(array[i].Length <= maxLenght)
    {
        newSize++;
    }
}