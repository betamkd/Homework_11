//Inheritance Homework_11

using Homework_11;
using System.ComponentModel;
using System.Transactions;

Person person = new Person();
Student student = new Student();

person.name = "Ed";
student.name = "Ed";
student.gradeLevel = "A";

var personGreet = person.Greet();
var studentGreet = student.Greet();

Console.WriteLine(personGreet);
Console.WriteLine(studentGreet);

Console.WriteLine($"****************************************\n");

Circle circle = new Circle();
Triangle triangle = new Triangle();
Rectangle rectangle = new Rectangle();

circle.Area = 0;
rectangle.Area = 0;
triangle.Area = 0;

var circleGetArea = circle.GetArea();
var rectangleGetArea = rectangle.GetArea();
var triangleGetArea = triangle.GetArea();


Console.WriteLine(circleGetArea);
Console.WriteLine(rectangleGetArea);
Console.Write(triangleGetArea);

Console.WriteLine($"****************************************\n");

BankAccount bankaccount = new BankAccount("200002552550707", 100);
int Balance = 100;
Console.ReadLine();
Console.WriteLine("Enter your deposit: ");
float Deposit = float.Parse(Console.ReadLine());
Console.WriteLine("How much would you like to withdraw?");
float Withdraw = float.Parse(Console.ReadLine());
Console.WriteLine(Balance + Deposit - Withdraw);

CheckingAccount checkingAccount = new CheckingAccount();
Console.WriteLine(checkingAccount.Balance);


SavingsAccount savingsaccount = new SavingsAccount();

Console.ReadLine();





//bankaccount.accountNumber = "200002552550707";
//bankaccount.balance = 400;

//var balanceDeposit = bankaccount.Deposit(); 
//var balanceWithdraw = bankaccount.Withdraw();

//var overdraftFeeWithdraw = checkingAccount.Withdraw();

//var savingsAccountCalculateInterest = savingsaccount.CalculateInterest();

//Console.WriteLine($"Bank account: {bankaccount.accountNumber}");
//var checkingAccounts = checkingAccount.ToString();