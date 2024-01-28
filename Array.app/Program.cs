namespace Array.app
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Telebenin sayini daxil edin");
            int studentCount = int.Parse(Console.ReadLine());
            string[] students = new string[studentCount];
            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine("Telkebenin adini daxil edin");
                string  name= Console.ReadLine();
                students[i] = name;
             }
            //Console.WriteLine("telebenin adlari asaqidaki kimidir");
            //for(int i = 0;i < studentCount;i++) 
            //{
            //    Console.WriteLine($" telebenin adi: {students[i]}");
                
            //}

            List<int> studentList = new List<int>();
            Console.WriteLine("***");
            //foreach (var item in students)
            //{
            //    Console.WriteLine(item);
            //}
            int index = 0;
            while (index < students.Length)
            {
                Console.WriteLine(students[index]);
                index++;

            }
           
        }
    }
}