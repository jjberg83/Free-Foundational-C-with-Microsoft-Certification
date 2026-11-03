// Bring in the Billing namespace
using Billing;

// Test på at jeg når metodene i Billing namespacet
Calculator.testPrint();

// Set up the order
double order = 100.00;

// Calculate tax and total
double tax = Calculator.CalculateTax(order);
double total = Calculator.CalculateTotal(order, tax);

// Print the receipt
