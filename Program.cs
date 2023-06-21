namespace Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape[] shapes = new Shape[]{new Circle(5), new Rectangle(4, 8), new Triangle(9, 6)};

            Console.WriteLine("The area of Circle = " + shapes[0].CalculateArea());
            Console.WriteLine("The area of Rectangle = " + shapes[1].CalculateArea());
            Console.WriteLine("The area of Triangle = " + shapes[2].CalculateArea());
            Console.WriteLine("------------------------------------------------");

            Animal[] animals = new Animal[] {new Dog(), new Cat(), new Cow()};

            foreach (Animal animal in animals)
            {
                animal.MakeSound();
            }
            Console.WriteLine("------------------------------------------------");

            Employee[] employees = new Employee[] { new FullTimeEmployee("Mohammed", 1000),new PartTimeEmployee("Ahmed", 700) };

            foreach (Employee employee in employees)
            {
                Console.WriteLine(employee.name + "'s bonus is " + employee.CalculateBonus());
            }
            Console.WriteLine("------------------------------------------------");

            BankAccount[] accounts = new BankAccount[] { new SavingsAccount("12345", 1000), new CheckingAccount("22222", 500, 100)};

            foreach (BankAccount account in accounts)
            {
                account.Withdraw(100);
                Console.WriteLine(account.accountNumber + " has balance " + account.balance);
            }
        }
    }
}