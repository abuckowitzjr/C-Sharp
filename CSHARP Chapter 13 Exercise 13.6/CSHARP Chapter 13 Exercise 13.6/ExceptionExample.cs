using System;

public class ExceptionExample
{
    private int _integer = 0;
    private decimal _decimal = 0;
    private string _string = "";

    public ExceptionExample(int integer, decimal dec, string str)
    {
        IntegerProperty = integer;
        DecimalProperty = dec;
        StringProperty = str;
    }

    public int IntegerProperty
    {
        get
        {
            return _integer;
        }
        private set
        {
            if (value >= 0)
                _integer = value;
            else
                throw new ArgumentOutOfRangeException("Integer", value, "Integer cannot be less than 0.");
        }
    }

    public decimal DecimalProperty
    {
        get
        {
            return _decimal;
        }
        private set
        {
            if (value >= 0)
                _decimal = value;
            else
                throw new ArgumentOutOfRangeException("Decimal", value, "Decimal cannot be less than 0.");
        }
    }

    public string StringProperty
    {
        get
        {
            return _string;
        }
        private set
        {
            if (value != "")
                _string = value;
            else
                throw new ArgumentOutOfRangeException("String", value, "String cannot be nothing.");
        }
    }
}