﻿int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

int [] array = {16, 21, 32, 14, 54, 61, 17, 28, 49};
//array [0] = 11;
//Console.WriteLine(array[1]);

int max = Max(
    Max(array[0], array[1], array[2]),
    Max(array[3], array[4], array[5]),
    Max(array[6], array[7], array[8])
);

Console.Write("max = ");
Console.WriteLine(max);



//int max1 = Max (a1, b1, c1);
//int max2 = Max (a2, b2, c2);
//int max3 = Max (a3, b3, c3);
//int max = Max(max1, max2, max3);

//Console.Write ("max = ");
//Console.WriteLine (max);