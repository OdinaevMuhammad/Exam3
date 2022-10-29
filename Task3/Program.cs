
int n = Convert.ToInt32(Console.ReadLine());
int f=1, sum = 1; 

for(int i=1;i<=n; i++)
{
    f*=2;
    sum=sum+f;
}

Console.WriteLine(sum);