int stopNumber=int.Parse(Console.ReadLine());
int num=int.Parse(Console.ReadLine());
double previousNumber = 0;

while(num!=stopNumber)
{   
    previousNumber=num;
    num = int.Parse(Console.ReadLine());
}
if (num == stopNumber)
{
    previousNumber = previousNumber * 1.2;
    Console.WriteLine(previousNumber);
}

