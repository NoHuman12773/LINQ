
int count = 0;
int max;
int[] a = new int[14];
Random random = new Random();
for (int i = 0; i < 14; i++)
{
    a[i] = random.Next(10, 100);
    Console.Write(a[i]+"");
    if (a[i] % 2 == 0)
    {
        count++;
    }
    Console.WriteLine("    " + count);
}
Console.WriteLine("\n");

IEnumerable<int> b = from c in a
                     where c % 2 == 0
                     select c;

foreach (int i in b)
{
    Console.Write(count + "  \n");
}