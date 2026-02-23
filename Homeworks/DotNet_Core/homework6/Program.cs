namespace homework6;

public delegate void MathDelegate(int[] array);
public delegate void StringDelegate(string text);

class Program
{
    static void CountVovel(string text)
    {
        string vovels = "aeiou";
        text = text.ToLower();
        int count = 0;
        foreach (char c in text)
        {
            if (vovels.Contains(c))
            {
                count++;
            }
        }
        Console.WriteLine($"Text have a  {count} vovels");
    }

    static void CountConsonants(string text)
    {
        string consonants = "bcdfghjklmnpqrstvwxyz";
        text = text.ToLower();
        int count = 0;
        foreach (char c in text)
        {
            if (consonants.Contains(c))
            {
                count++;
            }
        }
        Console.WriteLine($"Text have a  {count} consonants");
    }

    static void LenghtText(string text)
    {
        Console.WriteLine($"The text length is {text.Length}");
    }
    static void PrintArray(List<int> array)
    {
        foreach (int i in array)
        {
            Console.Write($"\t{i}");
        }
        Console.WriteLine();
    }
    static void FindEvenNumbers(int[] array)
    {
        List<int> evenNumbers = new List<int>();
        foreach (int i in array)
        {
            if (i % 2 == 0)
            {
                evenNumbers.Add(i);
            }
        }
        PrintArray(evenNumbers);
    }

    static void FindOddNumbers(int[] array)
    {
        List<int> oddNumbers = new List<int>();
        foreach (int i in array)
        {
            if (i % 2 != 0)
            {
                oddNumbers.Add(i);
            }
        }
        PrintArray(oddNumbers);
    }

    static void FindPrimeNumbers(int[] array)
    {
        List<int> primeNumbers = new List<int>();
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 2)
            {
                continue;
            }
            int count = 0;
            for (int j = 1; j <= array[i]; j++)
            {
                if (array[i] % j == 0)
                {
                    count++;
                }
            }
            if (count == 2)
            {
                primeNumbers.Add(array[i]);
            }
        }
        PrintArray(primeNumbers);
    }

    static void FindFibbonacciNumbersInArray(int[] array)
    {
        List<int> numbersToFind = FibbonacciNumbers();
        List<int> result = new List<int>();
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = 0; j < numbersToFind.Count; j++)
            {
                if (array[i] == numbersToFind[j])
                {
                    result.Add(array[i]);
                }
            }
        }
        PrintArray(result);
    }

    static List<int> FibbonacciNumbers()
    {
        List<int> numbers = new List<int>(){1,1};
        for (int i = 0; i < 10; i++)
        {
            numbers.Add(numbers[numbers.Count - 1] + numbers[numbers.Count - 2]);
        }
        return numbers;
    }

    static void task1()
    {
        int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        MathDelegate myDelegate = new MathDelegate(FindEvenNumbers);
        myDelegate += FindOddNumbers;
        myDelegate += FindPrimeNumbers;
        myDelegate += FindFibbonacciNumbersInArray;
        
        myDelegate(array);
    }

    static void task2()
    {
        string text = "Hello World!" +
                      "\nThis is a simple test string," +
                      "\ncreated to check vowels, consonants," +
                      "\nand the total length of the text.\n";
        
        StringDelegate myDelegate = new StringDelegate(CountVovel);
        myDelegate += CountConsonants;
        myDelegate += LenghtText;
        
        myDelegate(text);
    }
    
    static void Main(string[] args)
    {
        task1();
        task2();
    }
}