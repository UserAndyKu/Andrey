void FillArray(int[] Collection)            //Заполнение массива методом войд

{
    int length = Collection.Length;
    int index = 0;
    while (index < length)
    {
        Collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col)                  //Вывод массива после заполнения 

{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find)         //Поиск элемента массива 
{
    int count = collection.Length;
    int index = 0;
    int position = -1;
    while (index < count)
    {
        if (collection [index] == find)
        {
            position = index;
            break; 
        }
        index++;
    }
    return position;
}

int [] array = new int[15];

FillArray(array);
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 8);
Console.WriteLine(pos);
