int n;

n = Convert.ToInt32(Console.ReadLine());

var ar = new int[n];
for (int i = 0; i < n; i++)
{
    ar[i] = Convert.ToInt32(Console.ReadLine());
}
int cnt=0;
for (int i = 0; i < n; i++)
{
    
    if (ar[0] != ar[i])
    {
        cnt++;
    }
    
}
System.Console.WriteLine(cnt);