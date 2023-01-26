//Задача 37:
//Найдите произведение пар чисел в одномерном массиве. 
//Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
//Результат запишите в новом массиве.



    int CreatArr()
    {
      int number = Random.Shared.Next(5, 10);
      int[] arr =  new int[number];
      return arr;
    }
    void FillArray(int[] array)
    {
      for (int i = 0; i < array.Length; i++)
      {
        array[i] = Random.Shared.Next(10);
      }
    }
    string PrintArray(int[] priarray)
    {
      string output = string.Empty;
      int size = priarray.Length;
      for (int i = 0; i < size; i++)
      {
        output = output + $"{priarray[i]}";
      }
      return output;
    }
    int[] CountMult(int[] colection)
    {
      int[] arrMult = new int[colection.Length / 2];
      for (int i = 0; i < colection.Length / 2; i++)
      {
        arrMult[i] = colection[i] * colection[colection.Length - 1 - i];
      }
      return arrMult;
    }
    int[] arr = CreatArr();
    FillArray(arr);
    string Print = PrintArray(arr);
    Console.WriteLine(Print);
    int[] newArr = CountMult(arr);
    string newPrint = PrintArray(newArr);
    Console.WriteLine(newPrint);
  