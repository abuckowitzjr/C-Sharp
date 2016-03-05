using System;
using System.Numerics;

public class HugeInteger
{

    bool isEqualTo = true;

    public BigInteger Input(string number)
    {
        var chars = number.ToCharArray();
        BigInteger bi = BigInteger.Parse(number);
        return bi;
    }
    public string ToString(BigInteger value)
    {
        string output = value.ToString();
        return output;
    }
    public string Add(BigInteger number1, BigInteger number2)
    {
        BigInteger sum = number1 + number2;
        return ToString(sum);
    }
    public string Subtract(BigInteger number1, BigInteger number2)
    {
        BigInteger diff = 0;
        if (number1 > number2)
            diff = number1 - number2;
        else
            diff = number2 - number1;
        return ToString(diff);
    }
    public bool IsEqualTo()
    {
        bool result = false;

        return result;
    }
    public bool IsNotEqualTo()
    {
        bool result = false;

        return result;
    }
    public bool IsGreaterThan()
    {
        bool result = false;

        return result;
    }
    public bool IsLessThan()
    {
        bool result = false;

        return result;
    }
    public bool IsGreaterThanOrEqualTo()
    {
        bool result = false;

        return result;
    }
    public bool IsLessThanOrEqualTo()
    {
        bool result = false;

        return result;
    }
    public bool IsZero()
    {
        bool result = false;

        return result;
    }
    public int Multiply()
    {
        int result = 0;

        return result;
    }
    public int Divide()
    {
        int result = 0;

        return result;
    }
    public int Remainder()
    {
        int result = 0;

        return result;
    }









}