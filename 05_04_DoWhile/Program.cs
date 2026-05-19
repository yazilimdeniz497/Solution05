int[] grades=new int[3];
int i = 0;
do
{

    Console.WriteLine("Not Giriniz: ");
    grades[i] = Convert.ToInt32(Console.ReadLine());
    i++;
} while (i < grades.Length);
foreach(var grade in grades)
{
    Console.WriteLine($"Notlar:{grade}");
}
Console.ReadKey();