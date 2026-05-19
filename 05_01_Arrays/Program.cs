//dizi tanımlama
int[] numbers= new int[5];
//değer atama
numbers[0] = 10;
numbers[1] = 20;
numbers[2] = 30;
numbers[3] = 40;
numbers[4] = 50;
Console.WriteLine("Dizi elemanlarını tanımlama");
for(int i=0; i<numbers.Length; i++)
{
    Console.WriteLine(numbers[i]);
}
for (int i = numbers.Length - 1; i >= 0; i--)
{
    Console.WriteLine(numbers[i]);
}
Console.ReadKey();

