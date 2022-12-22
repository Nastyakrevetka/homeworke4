//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]

int DataInput (string str)
{
    Console.Write(str);
    int number= int.Parse(Console.ReadLine());
    return number;
}

int [] FillArray(int[] array)
{
    int length= array.Length;
    int index=0;
    for( int i=0; i<length;i++)
    {
        array[i]= new Random().Next(0,1000);
    }
    return array;
}
void PrintArray (int[] col)
{
    int count= col.Length;
    int i;
    for (i=0; i<count; i++)
    {
        Console.WriteLine( col[i]+ "");
    }
}
int Number=DataInput("Введите число: ");
int[] array= new int[Number];
array= FillArray(array);
PrintArray(array);