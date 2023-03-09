string[] CreatArray(){
    Console.Write("Задайте длину массива: ");
    int size = Convert.ToInt32(Console.ReadLine());
    string[] Array = new string [size];
    for (int i = 0; i < size; i++)
    {
        Console.Write("Задайте значение для " + i + " индекса: ");
        Array[i] = Console.ReadLine();
    }
    return Array;
}
string[] NewArrayOfThree(string[] ArrayFirst){
    int CounterOfThree = 0; //счетчик, считающий сколько раз в первом массиве присутствует строк с длиной 3 или меньше.
    for (int i = 0; i < ArrayFirst.Length; i++)
        if(ArrayFirst[i].Length <= 3)
            CounterOfThree++;
    string[] ArraySecond = new string [CounterOfThree];
    for (int i = 0; i < ArraySecond.Length; i++)
        for (int j = 0; j < ArrayFirst.Length; j++)
            if(ArrayFirst[j].Length <= 3)
            {
                ArraySecond[i] = ArrayFirst[j];
                i++;
            }
    return ArraySecond;
}

void PrintArray(string[] Array){
    Console.Write("[");
    for (int i = 0; i < Array.Length-1; i++)
        Console.Write(Array[i] + ", ");
    Console.WriteLine(Array[Array.Length-1] + "]");
}

string[] MyArray = CreatArray();
PrintArray(MyArray);
string[] MyNewArrayOfThree = NewArrayOfThree(MyArray);
PrintArray(MyNewArrayOfThree);
