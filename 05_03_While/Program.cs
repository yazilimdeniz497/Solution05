int[] numbers = { 0, 20, 30, 70, 5, -20, 50 };
int i = 0;
while (i < numbers.Length)
{
    if(numbers[i] < 0)
    {
        i++;
        continue;
      
       

    }
    Console.WriteLine($"Numaralar:{numbers[i]}");
    i++;



}
Console.ReadKey();