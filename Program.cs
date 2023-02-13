Console.WriteLine("Введите число");
int x = int.Parse(Console.ReadLine());
for (int y = 2; y <= x; y = y + 2)
{
    Console.WriteLine(y);
}
