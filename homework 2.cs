double balance;
double depositAmount;
double withdrawAmount;

Console.Write("Enter your initial balance: ");
balance = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter amount to deposit: ");
depositAmount = Convert.ToDouble(Console.ReadLine());
balance = balance + depositAmount;
Console.WriteLine($"You deposited {depositAmount}. New balance: {balance}");

Console.Write("Enter amount to withdraw: ");
withdrawAmount = Convert.ToDouble(Console.ReadLine());

if (withdrawAmount > balance)
{
    Console.WriteLine("Not enough balance.");
}
else
{
    balance = balance - withdrawAmount;
    Console.WriteLine($"You withdrew {withdrawAmount}. New balance: {balance}");
}

Console.WriteLine($"Your final balance is: {balance}");
