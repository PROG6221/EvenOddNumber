int[] arrNum = new int[10];
int[] arrEven = new int[10];
int[] arrOdd = new int[10];

int i, j = 0, k =0, n;

Console.WriteLine("Input the number of elements you would like your arrray to contain");
n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input {0} elements into the array :\n", n);

for(i = 0;i < n; i++)
{
    Console.WriteLine("element - {0}:", i);
    arrNum[i] = Convert.ToInt32(Console.ReadLine());
}

for(i = 0; i < n; i++)
{
    if (arrNum[i] % 2 == 0)
    {
        arrEven[j] = arrNum[i];
        j++;
    }
    else
    {
        arrOdd[k] = arrNum[i];
        k++;
    }

}

Console.WriteLine("EVEN NUMBERS ARE:");
for(i = 0; i < j; i++)
{
    Console.WriteLine("{0}", arrEven[i]);
}

Console.WriteLine("ODD NUMBERS ARE:");
for (i = 0; i < k; i++)
{
    Console.WriteLine("{0}", arrOdd[i]);
}