// Program, which out of the existing array forms another array, in which the lines are shorter than 3 or equal to 3 simbols

static string[] GetShortenedArray(string[] array)  
{                                                 
    int lengthLimit = 3;
    int elementsCount = 0;
    {
    for (int i = 0; i < array.Length; i++) 
    
        if (array[i].Length <= lengthLimit)   
            elementsCount++;   
    }

    string[] shortenedArray = new string[elementsCount];  
    int j = 0; 
    for (int i = 0; i < array.Length; i++)  
    
        if (array[i].Length <= lengthLimit)  
        {                            
            shortenedArray[j] = array[i];     
            j++;                                      
        }    
    return shortenedArray;
}

void printArray(string[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
        {
          Console.Write(array[i]);
          if (i < array.Length - 1)
            {
                Console.Write(", ");
            }
        }
    Console.WriteLine(" ]");
}

Console.WriteLine("Enter space-separated words and numbers");
string[] array = Console.ReadLine()!.Split();
Console.WriteLine();
printArray(array);
Console.WriteLine();
string[] shortenedArray = GetShortenedArray(array);
printArray(shortenedArray);