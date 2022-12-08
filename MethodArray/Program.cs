int [] array = {12, 23, 331, 14, 53, 65, 71, 825, 9};

int n = array.Length;
int find = 825;

int index = 0;

while (index < n)
{
    if(array [index] == find)
    {
        Console.WriteLine(index);
        // Нахождение указанного элемента массива и остановка дальнейшего поиска
        break; 
    }
    //index = index + 1;
    index++;
}