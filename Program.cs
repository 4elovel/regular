using System.Text.RegularExpressions;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("введіть текст:");
        string checker = @"(.*?\d.*?\d.*?\d[a-z]*?)";
        Regex reg = new Regex(checker);
        string buf = Console.ReadLine();
        if (buf.Length==9) {
            Console.WriteLine(reg.IsMatch(buf));
        }
        else
        {
            Console.WriteLine("False");
        }
    }
}