void ShowArray(string [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

    string[] finalArray = {"1234", "1567", "-2", "45", "cat"};
    string[] emptyArray = new string [10];


    for (int i=0; i<finalArray.Length; i++)
    {
      if (finalArray[i].Length <= 3)
     {
      emptyArray[i] = finalArray[i];
     }
    }

  
