// Bring in the Billing namespace
// Her vises det hvordan man kan lage aliaser for kun en klasse
// men ser ikke helt vitsen akkurat her.
using Calc = Billing.Calculator;

// Set up the order
double order = 100.00;

// Calculate tax and total
double tax = Calc.CalculateTax(order);
double total = Calc.CalculateTotal(order, tax);

// Lage en dansk ordre, med høyere skatt
double orderDanish = 100.00;
double taxDanish = Calc.CalculateTax(orderDanish, taxRate:0.38);
double totalDanish = Calc.CalculateTotal(orderDanish, taxDanish);

// Print the Norwegian receipt
Console.WriteLine($"{new string('-', 22)}\nReceipt \n{new string('-', 22)}");
Console.WriteLine(@$"{new string('-', 22)}
Order Receipt (Norsk)
{new string('-', 22)}
{"Amount:", -7} {order, 7:C}
{"Tax:", -7} {tax, 7:C}
{new string('-', 22)}
{"Total:", -7} {total, 7:C}
");

// :C får det til å bli Curency, slik
// Console.WriteLine($"{order:C}");

// Print the Danish receipt
Console.WriteLine(@$"{new string('-', 22)}
Order Receipt (Dansk)
{new string('-', 22)}
{"Amount:", -7} {orderDanish, 7:C}
{"Tax:", -7} {taxDanish, 7:C}
{new string('-', 22)}
{"Total:", -7} {totalDanish, 7:C}
");

// Annet alternativ for å printe (string literals)
Console.WriteLine($"""
{new string('-', 22)}
Order Receipt (Dansk)
{new string('-', 22)}
{"Amount:", -7} {orderDanish, 7:C}
{"Tax:", -7} {taxDanish, 7:C}
{new string('-', 22)}
{"Total:", -7} {totalDanish, 7:C}
""");