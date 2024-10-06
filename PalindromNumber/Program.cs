// See https://aka.ms/new-console-template for more information


int num;
int reverse = 0;
Console.WriteLine("Enter a number");
num = Convert.ToInt32(Console.ReadLine());
int temp = num;
while (temp > 0)
{
    int rem = temp % 10;
    reverse = reverse * 10 + rem;
    temp = temp / 10;          
}

if (num == reverse)
{
    Console.WriteLine("It is a palindrom Number");
    Console.ReadLine(); 
}
else
{
    Console.WriteLine("It is not a palindrom Number");
    Console.ReadLine();
}

