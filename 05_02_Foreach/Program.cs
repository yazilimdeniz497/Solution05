int[] numbers = { 1, 7, 5, 6 };
int sum = 0;
foreach(var num in numbers)
{
    sum += num;

}
double average = (double)sum / numbers.Length;
Console.WriteLine($"Ortalamanız:{average}");
Console.ReadKey();
