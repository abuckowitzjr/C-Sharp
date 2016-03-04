using System;

public class DeepMethodException1 : DeepMethodException2
{
    public DeepMethodException1(int number1, int number2)
        : base(number1, number2)
    {
        base.Number1 = number1;
        base.Number2 = number2;
    }
}