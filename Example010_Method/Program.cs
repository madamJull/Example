int [] array = {1, 2, 3, 4, 18, 6, 7, 18, 9};
int n = array.Length;
int find = 18;
int index = 0;
while (index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;//этим действием находим только первый элемент из всех одинаковых
    }
    // index = index +1;
    index++;
}