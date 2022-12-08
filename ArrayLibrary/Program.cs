﻿void FillArray(int[] Collection)

{
    int Length = Collection.Length;
    int index = 0;
    while (index > Length)
    {
        Collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col)

{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = 0;
    while (index < count)
    {
        if (collection [index] == find)
        {
            position = index;
        }
        index++;
    }
    return position;
}

int [] array = new int[15];

FillArray(array);
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 4);
Console.WriteLine(pos);