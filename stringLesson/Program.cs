namespace stringLesson;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a sentence: ");
        string sentence = Console.ReadLine();
        string[] words = sentence.Split(' ');
        string result = "";

        for (uint i = 0; i < words.Length; i++)
        {
            result += new string(words[i].Reverse().ToArray());
            result += " ";
        }
        Console.WriteLine(result);
    }
}