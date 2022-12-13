//Функции в программировании

//1) Работа с текстом //

string text = "- Я думаю, - сказал князь, улыбаясь, - что, "
            +"ежел бы вас послали вместо нашего млого Винценгероде,"
            +"вы бы взяли приступом согласие Прусского короля."
            +"Вы так красноречивы. Вы дадте мне чаю?";

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;

    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    
    return result;
}

//string newText = Replace (text, ' ', '|');
//Console.WriteLine(newText); 
//Console.WriteLine();

//newText = Replace (newText, 'к', 'К');
//Console.WriteLine(newText);
//Console.WriteLine();

//newText = Replace (newText, 'с', 'С');
//Console.WriteLine(newText);

//2)Работа с массивом данных
//1. Найти позицию миниального элемента в неотсортированной части массива
//2. Прозвести обмен этого значеня со значенем первой неотсортированной позиции
//3. Повторять, пока остаются неотсортированные элемента массива

int[] arr = {1, 7, 4, 2, 5, 3, 8, 6, 4, 2};

void PrintArray(int[] array)
{
    int count = array.Length;
    
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]}");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if(array[j] < array[minPosition])
            {
                minPosition = j;
            }
        }
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}
PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);