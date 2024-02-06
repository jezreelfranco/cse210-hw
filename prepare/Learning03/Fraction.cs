using System.Diagnostics;

public class Fraction
{
    private int _top;                      // good rule of thumb:
    private int _bottom;                   //     -> keep variables private, make functions public

    public Fraction ()                     // default constructor
    {                                      // doesn't return anything
         _top = 1;
         _bottom = 1;
    }

    public Fraction(int top)            // constructor that accepts member variables values
    {                                     // this returns the numertor and demonator as the values are set to the new variables within the constructor (the parameters of the constructor))
        _top = top;                       // setting values for method variables
       // _bottom = 1;
    }

    public Fraction (int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }
    
    // NUMERATOR
    public int GetNumerator()
    {
        return _top;
    }

    public void SetNumerator(int top)      // inputes value into "top" var
    {
        _top = top;
    }

    // BOTTOM
    public int GetDenominator()             // since we need to return variable, we set it to a int
    {
        return _bottom;
    }

    public void SetDenominator( int bottom)
    {
        _bottom = bottom;
    }

    public string GetFractionString()
    {
        return (_top + "/" + _bottom);
    }

    public double GetDecimalValue()
    {
        double decimalValue;
        decimalValue = (double)_top / (double)_bottom;
        return decimalValue;
    }
}