namespace Ogrodnik_lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var problem = new Problem(10, 1);
            Console.WriteLine(problem.ToString());
            var result =  problem.Solve(30);
            Console.WriteLine(result.ToString());

            

        }
    }
}