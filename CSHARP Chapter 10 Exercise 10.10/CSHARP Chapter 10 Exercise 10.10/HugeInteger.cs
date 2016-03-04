using System;

public class HugeInteger
{
    Random rnd = new Random();
    int[,] Digits = new int[1,40];
    public string output;

    public HugeInteger(int numberamount)
    {
        for (int counter = 1; counter <= numberamount; counter++)
            for (int digit = 1; digit <= 40; digit++)
                Digits[counter - 1, digit - 1] = rnd.Next(0, 10);
    }
    private string Input()
    {
        string result = "";

        return result;
    }
    private string ToString()
    {
        string result = "";

        return result;
    }
    private int Add()
    {
        int result = 0;

        return result;
    }
    private int Subtract()
    {
        int result = 0;

        return result;
    }
    private bool IsEqualTo()
    {
        bool result = false;

        return result;
    }
    private bool IsNotEqualTo()
    {
        bool result = false;

        return result;
    }
    private bool IsGreaterThan()
    {
        bool result = false;

        return result;
    }
    private bool IsLessThan()
    {
        bool result = false;

        return result;
    }
    private bool IsGreaterThanOrEqualTo()
    {
        bool result = false;

        return result;
    }
    private bool IsLessThanOrEqualTo()
    {
        bool result = false;

        return result;
    }
    private bool IsZero()
    {
        bool result = false;

        return result;
    }
    private int Multiply()
    {
        int result = 0;

        return result;
    }
    private int Divide()
    {
        int result = 0;

        return result;
    }
    private int Remainder()
    {
        int result = 0;

        return result;
    }









}