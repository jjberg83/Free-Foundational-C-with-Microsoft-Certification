namespace Billing
{
    public static class Calculator
    {
        // Add the CalculateTax and CalculateTotal methods here
        public static double CalculateTax(double order, double taxRate = 0.25)
        {
            return order * taxRate;   
        }

        public static double CalculateTotal(double order, double tax)
        {
            return order + tax;   
        }
    }
}