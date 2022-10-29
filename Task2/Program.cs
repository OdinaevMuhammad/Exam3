int n;

n = Convert.ToInt32(Console.ReadLine());

var ar = new int[n];
for (int i = 0; i < n; i++)
{
    ar[i] = Convert.ToInt32(Console.ReadLine());
}

int max=ar[0], end,min=ar[0],start;
for (int i = 0; i < n; i++)
{
    if(max<=ar[i])
    {
        max = ar[i];
        
    }
    end = max;
    if(min>=ar[i])
    {
        min = ar[i];
       
    }
    start = min;
    for (int i = start; i < max; i++)
    {
        System.Console.Write(ar[i]);
    }

}
