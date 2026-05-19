namespace _05_05_StudentApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] grades = { 50, 70, 80, 90, 85 };
            double average = calculateAverage(grades);
            Console.WriteLine(average);
            Console.ReadKey();
        }

        private static double calculateAverage(int[] grades)
        {
            int sum=0;
            foreach(var grade in grades)
            {
                sum += grade;
            


            }
            double average = sum / grades.Length;
            return average;

        }
    }
}
