namespace RegionApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int regCount = 3;
            string[] regions = new string[regCount];
            int[] populations = new int[regCount];
            for (int i = 0; i < regCount; i++)
            {
                Console.WriteLine("Please enter region name: ");
                string regionName = Console.ReadLine();
                Console.WriteLine("Please enter population count: ");
                int populationCount = int.Parse(Console.ReadLine());
                regions[i] = regionName;
                populations[i] = populationCount;

            }

            Console.WriteLine("Region information : ");
            for (int i = 0; i < regCount; i++)
            {
                Console.WriteLine($"Region name : {regions[i]} -- Population count: {populations[i]}");
            }
        }
    }
}