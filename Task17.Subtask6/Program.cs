namespace Task17.Subtask6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            StandartAccount standartAcc = new StandartAccount { Balance = random.Next(0, 10000)};
            SalaryAccount salaryAcc = new SalaryAccount { Balance = random.Next(0, 10000) };
            Calculator.CalculateInterest(standartAcc);
            Calculator.CalculateInterest(salaryAcc);
            Console.WriteLine(standartAcc.Interest);
            Console.WriteLine(salaryAcc.Interest);
            Console.ReadLine();
        }
    }
}