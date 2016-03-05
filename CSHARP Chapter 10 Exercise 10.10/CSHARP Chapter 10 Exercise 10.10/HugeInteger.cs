using System;
using System.Numerics;
using System.Text;

public class HugeInteger
{
    BigInteger num1 = 0; //For storing BigInteger values for use in the methods
    BigInteger num2 = 0;

    public void Input(string input1, string input2)
    {
        var chars1 = input1.ToCharArray(); //This could have been done without adding the strings to Char Array, but the book insisted I do so in this method so... yeah...
        var chars2 = input2.ToCharArray(); //
        string n1 = new String(chars1); //Creates new strings based on chars in arrays
        string n2 = new String(chars2); //
        num1 = BigInteger.Parse(n1); //Parses BigInteger numbers from new strings and stores in class variables
        num2 = BigInteger.Parse(n2); //
    }

    public void Clear() //Clears values in Biginteger variables when called from Main
    {
        num1 = 0;
        num2 = 0;
    }

    public string ToString(BigInteger value) //Converts any BigInteger value passed to it to string for use in Main for Console.Write
    {
        string output = value.ToString();
        return output;
    }

    public string ToString(Decimal value) //Converts any Decimal value passed to it to string for use in Main for Console.Write
    {
        string output = value.ToString();
        return output;
    }

    public BigInteger Add() //Adds numbers
    {
        BigInteger sum = num1 + num2;
        return sum;
    }
    public BigInteger Subtract() //Subtracts numbers
    {
        BigInteger diff = num1 - num2;
        return diff;
    }
    public bool IsEqualTo() //**Comparisons of numbers returning true or false
    {
        bool result = false;
        if (num1 == num2)
            result = true;
        return result;
    }
    public bool IsNotEqualTo() //**
    {
        bool result = false;
        if (num1 != num2)
            result = true;
        return result;
    }
    public bool IsGreaterThan() //**
    {
        bool result = false;
        if (num1 > num2)
            result = true;
        return result;
    }
    public bool IsLessThan() //**
    {
        bool result = false;
        if (num1 < num2)
            result = true;
        return result;
    }
    public bool IsGreaterThanOrEqualTo() //**
    {
        bool result = false;
        if (num1 >= num2)
            result = true;
        return result;
    }
    public bool IsLessThanOrEqualTo() //** 
    {
        bool result = false;
        if (num1 <= num2)
            result = true;
        return result;
    }
    public bool IsZero(string choice) //Checks if numbers passed in are zero
    {
        bool result = false;
        if (choice == "1")
        {
            if (num1 == 0)
                result = true;
        }
        if (choice == "2")
        {
            if (num2 == 0)
                result = true;
        }
        return result;
    }
    public BigInteger Multiply() //Returns product of numbers
    {
        BigInteger product = num1 * num2;
        return product;
    }
    public Decimal Divide() //Returns quotient of numbers
    {
        Decimal decnum1 = Convert.ToDecimal(ToString(num1));
        Decimal decnum2 = Convert.ToDecimal(ToString(num2));
        Decimal quotient = Math.Round(decnum1 / decnum2, 3);
        return quotient;
    }
    public Decimal Remainder() //Returns remainder of numbers
    {
        String strnum1 = ToString(num1);
        String strnum2 = ToString(num2);
        Decimal remainder = Math.Round(Convert.ToDecimal(strnum1) % Convert.ToDecimal(strnum2), 3);
        return remainder;
    }









}