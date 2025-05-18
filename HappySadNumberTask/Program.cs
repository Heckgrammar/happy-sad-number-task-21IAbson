namespace HappySadNumberTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*There are said to be happy numbers and sad numbers.
            Happy numbers will reduce to 1 when the digits belonging to the numbers are squared and added together to produce another number and the process is repeated. e.g. when we take 19
            1 squared is 1 , 9 squared is 81. 81 +1 = 82
            8 squared is 64, 2 squared is 4.  64 + 4 = 68
            6 squared is 36, 8 squared is 64, 36 + 64 = 100 
            1 squared is 1, 0 squared is 0 and thus the original number is reduced to 1
            Sad numbers will not reduce to 1 and will loop endlessly. e.g. when we take 20
            2 squared is 4, 0 squared is 0, 4 + 0 = 4
            4 squared is 16, 0 squared is 0, 16 + 0 = 16
            1 squared is 1, 6 squared is 36, 1 + 36 = 37
            3 squared is 9, 7 squared is 49, 9 + 49 = 58
            5 squared is 25, 8 squared is 64, 25 + 64 = 89
            8 squared is 64, 9 squared is 81, 64 + 81 = 145
            1 squared is 1, 4 squared is 16, 5 squared is 25, 1 + 16 + 25 = 42
            4 squared is 16, 2 squared is 4, 16 + 4 = 20
            20 will loop endlessly
            */
            //write a program to determine if a number is happy or sad
            //The program should take a number as input and output whether the number is happy or sad
            //test your program with the inputs of 19 and 20
            //show your output in the readme file


            Console.WriteLine("What number do you want?");
            string num = Console.ReadLine();
            double num2 = 0;
            double num3 = 0;
            string num4 = num;
            int count = 0;
            bool valid = true;
            for (int i = 0; i < num.Length; i++)
            {
                num2 = num[i] - 48;
                Console.WriteLine(num[i] - 48);
                num3 = num3 + (num2 * num2);
                Console.WriteLine(num3);

            }
            num = Convert.ToString(num3);
            Console.WriteLine(num);
            while (num != "1")
            {
                num3 = 0;
                for (int i = 0; i < num.Length; i++)
                {

                    num2 = num[i] - 48;
                    Console.WriteLine(num2);
                    num3 = num3 + (num2 * num2);
                    Console.WriteLine(num3);

                }
                num = Convert.ToString(num3);
                if (num == num4 || num == "4")
                {
                    valid = false;
                    break;
                }

            }
            if (valid == true)
            {
                Console.WriteLine("Your number is happy");
            }
            else
            {
                Console.WriteLine("Your number is sad");
            }
            //works for happy nums
















        }
    }
}
