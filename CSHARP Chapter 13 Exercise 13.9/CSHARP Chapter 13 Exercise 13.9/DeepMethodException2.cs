using System;

public class DeepMethodException2
{
    private int _num2;

    public DeepMethodException2(int number1, int number2)
    {
        Number1 = number1;
        Number2 = number2;
    }

    public int Number1 { get; set; }

    public int Number2
    {
        get
        {
            return _num2;
        }
        set
        {
            if (value > 0)
                _num2 = value;
            else
                throw new DivideByZeroException("Number 2 cannot be 0, will cause divide by zero error.");
        }
    }

    public int Calculate(int num1, int num2)
    {
        int result;
        result = num1 / num2;
        return result;
    }
}