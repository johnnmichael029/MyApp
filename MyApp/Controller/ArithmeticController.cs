using System;

namespace MyApp.Controller
{
    public class ArithmeticController
    {
        public double Addition(double a, double b)
        {
            try
            {
                return a + b;
            }
            catch (Exception ex)
            {
                throw new Exception("Error in Addition: " + ex.Message);
            }
        }

        public double Subtraction(double a, double b)
        {
            try
            {
                return a - b;
            }
            catch (Exception ex)
            {
                throw new Exception("Error in Subtraction: " + ex.Message);
            }
        }

        public double Multiplication(double a, double b)
        {
            try
            {
                return a * b;
            }
            catch (Exception ex)
            {
                throw new Exception("Error in Multiplication: " + ex.Message);
            }
        }

        public double Division(double a, double b)
        {
            try
            {
                if (b == 0)
                {
                    throw new DivideByZeroException("Cannot divide by zero!");
                }
                return a / b;
            }
            catch (Exception ex)
            {
                throw new Exception("Error in Division: " + ex.Message);
            }
        }
    }
}
