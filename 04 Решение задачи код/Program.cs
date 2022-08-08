// написать программу которая из массива найдет элементы с тремя и менее символами и выведет их в отдельный массив

string [] array1 = new string [5] {"56", "good", "67", "moscow", "no"};
string [] array2 = new string [array1.Length];
void Kontrolnaya(string[] array1, string[] array2)
    { 
   int count = 0;
   for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length<= 3)
        {
        array2[count] = array1[i];
        count++;
        }
    }
    }
 void printArray (string [] array)
 {
     for (int i = 0; i < array1.Length; i++)
     {
        Console.Write (array[i] + " "); 
     }

 }

 Kontrolnaya(array1, array2);
printArray (array2);