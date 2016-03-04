using System;

public class ComplexNumbers
{
    private float c1Real;
    private float c1Imag;
    private float c2Real;
    private float c2Imag;
    private float AddCompR;
    private float SubCompR;
    private float AddCompI;
    private float SubCompI;

    public ComplexNumbers()
    {
        Complex1R = 1;
        Complex1I = 1;
        Complex2R = 1;
        Complex2I = 1;
        AddReal = AddCompReal(Complex1R, Complex2R);
        SubReal = SubCompReal(Complex1R, Complex2R);
        AddImag = AddCompImag(Complex1I, Complex2I);
        SubImag = SubCompImag(Complex1I, Complex2I);
    }
    public ComplexNumbers(float complex1Real, float complex1Imag, float complex2Real, float complex2Imag)
    {
        Complex1R = complex1Real;
        Complex1I = complex1Imag;
        Complex2R = complex2Real;
        Complex2I = complex2Imag;
        AddReal = AddCompReal(Complex1R, Complex2R);
        SubReal = SubCompReal(Complex1R, Complex2R);
        AddImag = AddCompImag(Complex1I, Complex2I);
        SubImag = SubCompImag(Complex1I, Complex2I);
    }
    private float Complex1R 
    {
        get
        {
            return c1Real;
        }
        set
        {
            c1Real = value;
        }
    }
    private float Complex1I 
    {
        get
        {
            return c1Imag;
        }
        set
        {
            c1Imag = value * (float)Math.Sqrt(-1);
        }
    }
    private float Complex2R
    {
        get
        {
            return c2Real;
        }
        set
        {
            c2Real = value;
        }
    }
    private float Complex2I 
    {
        get
        {
            return c2Imag;
        }
        set
        {
            c2Imag = value * (float)Math.Sqrt(-1);
        }
    }
    public float AddReal
    {
        get
        {
            return AddCompR;
        }
        private set
        {
            AddCompR = value;
        }
    }
    public float SubReal
    {
        get
        {
            return SubCompR;
        }
        private set
        {
            SubCompR = value;
        }
    }
    public float AddImag
    {
        get
        {
            return AddCompI;
        }
        private set
        {
            AddCompI = value;
        }
    }
    public float SubImag
    {
        get
        {
            return SubCompI;
        }
        private set
        {
            SubCompI = value;
        }
    }
    private float AddCompReal(float C1R, float C2R)
    {
        float result;
        result = C1R + C2R;
        return result;
    }
    private float SubCompReal(float C1R, float C2R)
    {
        float result;
        result = C1R - C2R;
        return result;
    }
    private float AddCompImag(float C1I, float C2I)
    {
        float result;
        result = (float)((C1I * Math.Sqrt(-1)) + (C2I * Math.Sqrt(-1)));
        return result;
    }
    private float SubCompImag(float C1I, float C2I)
    {
        float result;
        result = (float)((C1I * (float)Math.Sqrt(-1)) - (C2I * (float)Math.Sqrt(-1)));
        return result;
    }












}