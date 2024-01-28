namespace NestedForExample1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int studentCount = 3;
            string[] students = new string[studentCount];
            int[] grades = new int[studentCount];
            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine("Telebenin adini daxil ediniz:");
                string name=Console.ReadLine();
                Console.WriteLine("Telebenin qiymetini daxil ediniz:");
                int grade=int.Parse(Console.ReadLine());
                students[i] = name;
                grades[i] = grade;
            }
            Console.WriteLine("Telebelerin adi ve qiymetleri asagidaki kimidir:");
            Console.WriteLine("********");

            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine($"Students name: {students[i]} -- Students grade: {grades[i]}");
            }

            
        }
    }
}