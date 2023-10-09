// See https://aka.ms/new-console-template for more information

int num = int.Parse(Console.ReadLine());
int lastDigit = 0;
bool isSpecial = true;

while (num>0)
{
    lastDigit = num % 10;
    if(num%lastDigit != 0)
    {
        isSpecial = false;
        break;
    }
    num /= 10;
}
if (!isSpecial)
{
    Console.WriteLine($"{num} is not special");
    
}
else
{
    Console.WriteLine($"{num} is special");
}
