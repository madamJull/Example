﻿int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}//индекс элем   0  1  2  3  4  5  6  7  8   
int  [] array = {1, 2, 3, 4, 5, 6, 7, 811, 9};
array [0] = 12;
Console.WriteLine(array [0]);
int result = Max(
    Max(array[0], array[1], array[2]),
    Max(array[3], array[4], array[5]),
    Max(array[6], array[7], array[8])
);
Console.WriteLine(result);

//Решение 1
//int a1 = 15;
//int b1 = 21;
//int c1 = 39;
//int a2 = 12;
//int b2 = 23;
//int c2 = 33;
//int a3 = 12;
//int b3 = 23;
//int c3 = 33;

//int max = a1;
//if (b1 > max) max = b1;
//if (c1 > max) max = c1;

//if (a2 > max) max = a2;
//if (b2 > max) max = b2;
//if (c2 > max) max = c2;

//if (a3 > max) max = a3;
//if (b3 > max) max = b3;
//if (c3 > max) max = c3;

//Console.WriteLine(max);
