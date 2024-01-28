namespace ListApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> grades = new List<int>();

            char flag = 'x';
            do
            {
                Console.WriteLine("Telebenin qiymetini daxil ediniz");
                int grade = int.Parse(Console.ReadLine());
                grades.Add(grade);

                Console.WriteLine("Davam etmek isteyirsenmi?(b/x)");
                flag = char.Parse(Console.ReadLine());
            } while (flag=='b'||flag=='B');

            foreach (var item in grades)
            {
                Console.WriteLine(item);
            }
        }
    }
}