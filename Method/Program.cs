//Методы 
//Вид 1
void Method1()
{
    Console.WriteLine("...");
}
//Method1();

//Вид 2     Ничего не возвращает, но принимает аргументы
void Method2(string msg)
{
    Console.WriteLine(msg);
}
//Method2(msg: "Text");

void Method21(string msg, int count)
{
    int i = 0;
    while(i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
//Method21(msg: "Text", count: 3);

//Вид 3 Что-то принмают, но ничего не возвращают

int Method3()
{
    return DateTime.Now.Year;
}

//int year = Method3();
//Console.WriteLine(year);



//Вид 4 Что-то принимает, и что-то возвращает

//string Method4(int count, string c)
//{
    //int i=0;
    //string result = String.Empty;

    //while (i < count)
    //{
        //result = result + c;
        //i++;
    //}
    //return result;
//}

//string res = Method4(3, "text random, ");
//Console.WriteLine(res);

string Method41(int count, string c)
{
    string result = String.Empty;
    for(int i = 0;i < count; i++)
    {
        result = result + c;
    }
    return result;
}

string res = Method41(5, "text random, ");
//Console.WriteLine(res);

for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i} x {j} = {i * j}");
    }
    Console.WriteLine();
}