using System;

public class Rational
{
    private int _numerator1;
    private int _denominator1;
    private int _numerator2;
    private int _denominator2;
    private int _decplaces;
    private string CalcDecA;
    private string CalcDecS;
    private string CalcDecM;
    private string CalcDecD;
    private string add;
    private string subtract;
    private string multiply;
    private string divide;

    public Rational()
    {
        Numerator1 = 1;
        Denominator1 = 1;
        Numerator2 = 1;
        Denominator2 = 1;
        DecPlaces = 2;
        Add = AddRationalNumbers(Numerator1, Denominator1, Numerator2, Denominator2);
        Subtract = SubtractRationalNumbers(Numerator1, Denominator1, Numerator2, Denominator2);
        Multiply = MultiplyRationalNumbers(Numerator1, Denominator1, Numerator2, Denominator2);
        Divide = DivideRationalNumbers(Numerator1, Denominator1, Numerator2, Denominator2);
    }
    public Rational(int numerator1, int denominator1, int numerator2, int denominator2, int decplaces)
    {
        Numerator1 = numerator1;
        Denominator1 = denominator1;
        Numerator2 = numerator2;
        Denominator2 = denominator2;
        DecPlaces = decplaces;
        Add = AddRationalNumbers(Numerator1, Denominator1, Numerator2, Denominator2);
        Subtract = SubtractRationalNumbers(Numerator1, Denominator1, Numerator2, Denominator2);
        Multiply = MultiplyRationalNumbers(Numerator1, Denominator1, Numerator2, Denominator2);
        Divide = DivideRationalNumbers(Numerator1, Denominator1, Numerator2, Denominator2);
    }
    public string CalcDecimalA
    {
        get
        {
            return CalcDecA;
        }
    }
    public string CalcDecimalS
    {
        get
        {
            return CalcDecS;
        }
    }
    public string CalcDecimalM
    {
        get
        {
            return CalcDecM;
        }
    }
    public string CalcDecimalD
    {
        get
        {
            return CalcDecD;
        }
    }
    public string Add
    {
        get
        {
            return add;
        }
        private set
        {
            add = value;
        }
    }
    public string Subtract
    {
        get
        {
            return subtract;
        }
        private set
        {
            subtract = value;
        }
    }
    public string Multiply
    {
        get
        {
            return multiply;
        }
        private set
        {
            multiply = value;
        }
    }
    public string Divide
    {
        get
        {
            return divide;
        }
        private set
        {
            divide = value;
        }
    }
    public int DecPlaces
    {
        get
        {
            return _decplaces;
        }
        private set
        {
            _decplaces = value;
        }
    }
    public int Numerator1
    {
        get
        {
            return _numerator1;
        }
        private set
        {
            _numerator1 = value;
        }
    }
    public int Denominator1
    {
        get
        {
            return _denominator1;
        }
        private set
        {
            _denominator1 = value;
        }
    }
    public int Numerator2
    {   
        get
        {
            return _numerator2;
        }
        private set
        {
            _numerator2 = value;
        }
    }
    public int Denominator2
    {
        get
        {
            return _denominator2;
        }
        private set
        {
            _denominator2 = value;
        }
    }
    private string CalcDec(decimal num, decimal den)
    {
        string result;
        result = (num / den).ToString("F" + DecPlaces);
        return result;
    }
    private string AddRationalNumbers(int numerator1, int denominator1, int numerator2, int denominator2)
    {
        string result;
        int numtot;
        int denomtot;
        numtot = (numerator1 * denominator2) + (numerator2 * denominator1);
        denomtot = (denominator1 * denominator2);
        result = numtot + "/" + denomtot;
        CalcDecA = CalcDec((decimal)numtot, (decimal)denomtot);
        return result;
    }
    private string SubtractRationalNumbers(int numerator1, int denominator1, int numerator2, int denominator2)
    {
        string result;
        int numtot;
        int denomtot;
        numtot = (numerator1 * denominator2) - (numerator2 * denominator1);
        denomtot = (denominator1 * denominator2);
        result = numtot + "/" + denomtot;
        CalcDecS = CalcDec((decimal)numtot, (decimal)denomtot);
        return result;
    }
    private string MultiplyRationalNumbers(int numerator1, int denominator1, int numerator2, int denominator2)
    {
        string result;
        int numtot;
        int denomtot;
        numtot = (numerator1 * numerator2);
        denomtot = (denominator1 * denominator2);
        result = numtot + "/" + denomtot;
        CalcDecM = CalcDec((decimal)numtot, (decimal)denomtot);
        return result;
    }
    private string DivideRationalNumbers(int numerator1, int denominator1, int numerator2, int denominator2)
    {
        string result;
        int numtot;
        int denomtot;
        numtot = (numerator1 * denominator2);
        denomtot = (denominator1 * numerator2);
        result = numtot + "/" + denomtot;
        CalcDecD = CalcDec((decimal)numtot, (decimal)denomtot);
        return result;
    }
}