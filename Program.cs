using System;

namespace String_1
{
    public class Logic
    {
        public static int Change(string str)
        {
            int count = 0;
            for (int i = 0; i < str.Length - 1; i++)
            {
                if (str[i] == str[i + 1] && char.IsLetter(str[i])) count++;
            }
            return count;
        }

        class Program
        {
            static void Main(string[] args)
            {
                string str = Console.ReadLine();
                
                Console.WriteLine(Logic.Change(str));



            }
        }
    }
}

