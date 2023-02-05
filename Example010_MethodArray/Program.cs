//               0   1   2   3   4   5   6   7   8 
int[] array = { 31, 52, 47, 23, 47, 55, 66, 74, 68 };

int n = array.Length;
int find = 47;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break; // при наличии одинаковых елементов в массиве, этот оператор заканчивает работу цикла на 1м найденном значении.
    }
    index++;
}

