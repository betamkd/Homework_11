//Inheritance Homework_11

using Homework_11;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
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

BankAccount bankaccount = new BankAccount();
CheckingAccount checkingAccount = new CheckingAccount();
SavingsAccount savingsaccount = new SavingsAccount();

bankaccount.AccountNumber = "Your Account Number: 200002552660707";
bankaccount.Balance = 1500;
var depositAccount = bankaccount.Deposit();
var withdrawAccount = bankaccount.Withdraw();
checkingAccount.OverdraftFee = 250;	
var withdrawBankAccount = checkingAccount.Withdraw();
savingsaccount.InterestRate = checkingAccount.Balance * 5/100;
var calculateInterest = savingsaccount.CalculateInterest();

Console.WriteLine(bankaccount.AccountNumber);
Console.WriteLine($"Your balance is: {bankaccount.Balance}");
Console.WriteLine($"Please deposit money: {bankaccount.Deposit()}");
Console.WriteLine($"Please withdraw money:{bankaccount.Withdraw()}");
Console.WriteLine($"Overdraft fee: {checkingAccount.OverdraftFee}");
Console.WriteLine($"Your current balance is: {checkingAccount.Balance}");
Console.WriteLine(savingsaccount.InterestRate);
Console.WriteLine(savingsaccount.CalculateInterest());

Console.WriteLine($"****************************************\n");






//string BankAccount = "";
//Console.WriteLine("Enter your Bank Account: ");
//Console.ReadLine();
//float Balance = 0;
//Console.WriteLine("Enter your deposit: ");
////float Deposit = float.Parse(Console.ReadLine());







//Console.WriteLine("How much would you like to withdraw?");
//float Withdraw = float.Parse(Console.ReadLine());
//Console.WriteLine($"Your balance is: {Balance + Deposit - Withdraw}");







//var withdrawFinal = checkingAccount.Withdraw();
//float OverdraftFee = 50;
//Console.WriteLine($"The Overdraft fee is: {OverdraftFee}");
//Console.WriteLine($"Your current account balance is: {withdrawFinal} ");



//Console.ReadLine();





//bankaccount.accountNumber = "200002552550707";
//bankaccount.balance = 400;

//var balanceDeposit = bankaccount.Deposit(); 
//var balanceWithdraw = bankaccount.Withdraw();

//var overdraftFeeWithdraw = checkingAccount.Withdraw();

//var savingsAccountCalculateInterest = savingsaccount.CalculateInterest();

//Console.WriteLine($"Bank account: {bankaccount.accountNumber}");
//var checkingAccounts = checkingAccount.ToString();