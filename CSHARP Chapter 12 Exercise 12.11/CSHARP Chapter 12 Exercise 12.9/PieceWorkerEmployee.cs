using System.Timers;
using System;

public class PieceWorkerEmployee : Employee
{
     private decimal wage;
    private int pieces;
    private int _birthMonth;

    public PieceWorkerEmployee(string first, string last, string ssn, int birthMonth, int birthDay, int birthYear, decimal hourlyWage, int piecesCompleted)
        : base(first, last, ssn, birthMonth, birthDay, birthYear)
    {
        Wage = hourlyWage;
        Pieces = piecesCompleted;
        BirthMonth = birthMonth;
    }

    public int BirthMonth
    {
        get
        {
            return _birthMonth;
        }
        private set
        {
            _birthMonth = value;
        }
    }
    public decimal Wage
    {
        get
        {
            return wage;
        }
        set
        {
            if (value >= 0)
                wage = value;
            else
                throw new ArgumentOutOfRangeException("Wage", value, "Wage must be >= 0");
        }
    }

    public int Pieces
    {
        get
        {
            return pieces;
        }
        set
        {
            if (value >= 0)
                pieces = value;
            else
                throw new ArgumentOutOfRangeException("Pieces", value, "Pieces must be >= 0");
        }
    }

    public override decimal Earnings()
    {
            if (BirthMonth == DateTime.Now.Month)
                return (Wage * Pieces) + 100;
            else
                return Wage * Pieces;
    }

    public override string ToString()
    {
        return string.Format("piece worker: {0}\n{1}: {2:C}; {3}: {4:F2}", base.ToString(), "piece wage", Wage, "pieces completed", Pieces);
    }




}