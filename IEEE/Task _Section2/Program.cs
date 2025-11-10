using System;

// ====================== Task 1 ======================
class clsBankAccount
{
    public string AccountNumber { get; }
    public string OwnerName { get; set; }
    public double Balance { get; private set; }

    public clsBankAccount(string accountNumber, string ownerName)
    {
        AccountNumber = accountNumber;
        OwnerName = ownerName;
        Balance = 0;
    }

    public clsBankAccount(string accountNumber, string ownerName, double initialBalance)
    {
        AccountNumber = accountNumber;
        OwnerName = ownerName;
        Balance = initialBalance;
    }

    public void Deposit(double amount)
    {
        if (amount > 0)
            Balance += amount;
    }

    public void Withdraw(double amount)
    {
        if (amount > 0 && amount <= Balance)
            Balance -= amount;
    }
}

// ====================== Task 2 ======================
class clsVehicle
{
    public int Speed { get; set; }

    public virtual void Move()
    {
        Console.WriteLine($"Vehicle is moving at {Speed} km/h");
    }
}

class clsCar : clsVehicle
{
    public string Model { get; set; }

    public clsCar(string model)
    {
        Model = model;
    }

    public override void Move()
    {
        Console.WriteLine($"Car Model {Model} is moving at {Speed} km/h");
    }

    public void Move(int newSpeed)
    {
        Speed = newSpeed;
        Console.WriteLine($"Car Model {Model} is moving at {Speed} km/h");
    }
}

// ====================== Task 3 ======================
interface IWorkable
{
    void Work();
}

abstract class clsEmployee : IWorkable
{
    public string Name { get; set; }
    public double Salary { get; set; }

    public clsEmployee(string name, double salary)
    {
        Name = name;
        Salary = salary;
    }

    public abstract double CalculateBonus();
    public abstract void Work();
}

class clsFullTimeEmployee : clsEmployee
{
    public clsFullTimeEmployee(string name, double salary) : base(name, salary) { }

    public override double CalculateBonus()
    {
        return Salary * 0.20;
    }

    public override void Work()
    {
        Console.WriteLine($"{Name} is working full time.");
    }
}

class clsPartTimeEmployee : clsEmployee
{
    public clsPartTimeEmployee(string name, double salary) : base(name, salary) { }

    public override double CalculateBonus()
    {
        return Salary * 0.10;
    }

    public override void Work()
    {
        Console.WriteLine($"{Name} is working part time.");
    }
}
class Program
{
    static void Main()
    {
        Console.WriteLine("=== Task 1 ===");
        clsBankAccount acc1 = new clsBankAccount("123", "Ali");
        acc1.Deposit(500);
        acc1.Withdraw(200);
        Console.WriteLine(acc1.Balance);

        Console.WriteLine("\n=== Task 2 ===");
        clsCar myCar = new clsCar("BMW");
        myCar.Move();
        myCar.Move(120);

        Console.WriteLine("\n=== Task 3 ===");
        clsEmployee e1 = new clsFullTimeEmployee("Ahmed", 10000);
        e1.Work();
        Console.WriteLine($"{e1.Name} Bonus: {e1.CalculateBonus()}");

        clsEmployee e2 = new clsPartTimeEmployee("Sara", 500);
        e2.Work();
        Console.WriteLine($"{e2.Name} Bonus: {e2.CalculateBonus()}");
    }
}
