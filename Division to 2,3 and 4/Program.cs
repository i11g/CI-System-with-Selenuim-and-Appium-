namespace Division_to_2_3_and_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num=int.Parse(Console.ReadLine());

            double divisibleTwo = 0;
           double divisibleThree = 0;
            int divisibleFour = 0;

            for (int i = 0; i <num; i++)
            {
                int numbers = int.Parse(Console.ReadLine());
                if(numbers%2== 0)
                {
                    divisibleTwo++;
                }
                if (numbers%3==0)
                {
                    divisibleThree++;
                }
                if (numbers % 4 == 0)
                {
                    divisibleFour++;
                }
            }
            Console.WriteLine($"{divisibleTwo/num*1.00:f2}%");
            Console.WriteLine($"{divisibleThree/num*1.00:f2}%");
            Console.WriteLine($"{(double)divisibleFour/num*1.00:f2}%");
        }
    }
}