// Задача 1: Задайте двумерный массив символов (тип char [,]). 
// Создать строку из символов этого массива.


void Print2DArray(char[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(array[i, j] + " ");
        }
        System.Console.WriteLine();
    }
}

string Concat(char[,] array)
{
    string str = "";
    for (int i = 0; i < array.GetLength(0); i++)
    {   
        for (int j = 0; j < array.GetLength(1); j++)
        {
            str = str + array[i,j];
        }
        
    }
    return str;
}

void PrintArray(string array)
{
    System.Console.WriteLine(array);
}

char[,] chars = {{'a', 'b', 'c'},{'d', 'e', 'f'}};
Print2DArray(chars);
string result = Concat(chars);
PrintArray(result);