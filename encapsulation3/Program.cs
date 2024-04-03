namespace encapsulation3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("inara", true, 1500);
            Manager manager = new Manager();
            manager.GetPromotion(employee);
            Assistan assistant = new Assistan();
            assistant.GetFeedback(employee);
        }
    }
}
