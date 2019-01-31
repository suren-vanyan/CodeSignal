using System;

namespace lineEncoding
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "ssiiggkooo";
            Console.WriteLine(lineEncoding(s));
        }

        static string lineEncoding(string s)
        {
           

            char temp = s[0];
            string result = string.Empty;
            int counter = 1;
            for (int i = 1; i < s.Length; i++)
            {
                if (temp == s[i])
                    counter++;
                else
                {
                    if (counter > 1)
                        result += counter.ToString() + temp;
                    else
                        result += temp;
                    counter = 1;
                    temp = s[i];
                }
            }

            if (counter > 1) result += counter.ToString() + temp;
            else result += temp;
            return result;

        }
    }
}
