// Перемножить матрицу 
/*
1. Задать матрицу1 и матрицу2
2.создать метод по заполнению матрицыу1 и матрицы2
3. распечатать матрицу1 и матрицу2
4. Метод проверки возможности перемножения матриц, число стобцов первой матрицы не равно числу строк второй матрицы 
5.Метод перемножения марицы 1 на матрицу2
*/ 
void FillArray(int[,] matr)// метод для заполнения матрицы случайными числами
{
    for (int i = 0; i < matr.GetLength(0); i++)  // GetLength(0) - возвращает кол-во строк
    {
        for (int j = 0; j < matr.GetLength(1); j++)  // GetLength(1) - возвращает кол-во столбцов
        {
            matr[i, j] = new Random().Next(1, 10);// [1,10)- полуинтервал,т.е. 10- не войдет
        }
    }
}

void PrintArray(int[,] matr)  // метод для печати двумерного массива
{
    for (int i = 0; i < matr.GetLength(0); i++)  // GetLength(0) - чтобы не писать каждый раз кол-во строк
    {
        for (int j = 0; j < matr.GetLength(1); j++)  // GetLength(1) - чтобы не писать каждый раз кол-во столбцов
        {
            Console.Write($"{matr[i, j]} ");

        }
        Console.WriteLine();
    }
}



int [,] matrixA = new int [2,2];
int [,] matrixB = new int [2,1];

int stlbmatrixA = matrixA.GetLength(1);
int sringmatrixB = matrixB.GetLength(0);
if (stlbmatrixA == sringmatrixB )
{
    
    else 
    Console.WriteLine("Матрицы не перемножаются");
}
FillArray(matrixA);
PrintArray(matrixA);
Console.WriteLine();
FillArray(matrixB);
PrintArray(matrixB);
