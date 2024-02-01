namespace premierCourProg2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5 - i; j++)
                {
                    Console.Write(' ');
                }
                for (int k = 1; k <= i; k++)
                {
                    Console.Write(' ');
                    Console.Write('*');
                }
                Console.Write("\n");
            }
        }
    }
}