namespace TwoDimentionArrayApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] arr2d = new int[3, 4];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.WriteLine($"{i + 1} Telebenin {j + 1} qiymetini girin");
                    int point = int.Parse(Console.ReadLine());
                    arr2d[i, j]=point;


                }
            }
            Console.WriteLine("Telebelerin qiymeti asaqidaki kimidir");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(arr2d[i, j]+ " ; ");

                }
                Console.WriteLine();
            }
        }
    }
}