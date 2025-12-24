using System;
public abstract class UnitConverter
{
    protected double value;
    protected double result;
    protected string fromUnit;
    protected string toUnit;
    public abstract double Convert(double value, string fromUnit, string toUnit);
    public abstract double Convert(double value, string fromUnit);
}