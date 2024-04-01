namespace LabTask17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee[] employees = { new FullTimeEmployee("Eli", 1, 1000, 10), new FullTimeEmployee("Veli", 2, 3000, 5), 
                new PartTimeEmployee("Pirveli", 3, 2500, 58), new PartTimeEmployee("Ad", 4, 5000, 78) };

            for (int i = 0; i < employees.Length; i++)
            {
                employees[i].DisplayInfo();
            }
        }
    }
}
