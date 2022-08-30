Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степень: ");
int n = Convert.ToInt32(Console.ReadLine());

int num_n=1;
for(int i = 0; i < n; i++) 
{
    num_n *= num;
}

Console.Write("{0} ^ {1} = {2}", num, n, num_n);