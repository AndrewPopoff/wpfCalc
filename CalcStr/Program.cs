using System;

namespace CalcStr
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "Привет, ";
            string str2 = "мир!";
            string str = str1 + str2;
            Console.WriteLine(str);

            int len = str1.Length;
            Console.WriteLine(len);

            char a = 'a';
            char b = 'b';
            int aInt = (int)a;
            int bInt = (int)b;
            char c = (char)((int)b + 1);

            for(int i = aInt;i<= (int)'z'; i ++)
            {
                Console.Write((char)i);
            }
            Console.WriteLine();

            char cFirst = str[0];
            char cLast = str[str.Length - 1];

            for(int i =0; i< str.Length; i++)
            {
                Console.Write(str[i] + " ");
            }
            Console.WriteLine();

            str = str.Remove(1, 1);
            Console.WriteLine(str);

            str = str.Remove(str.Length - 1, 1);
            Console.WriteLine(str);
        }
    }
}
