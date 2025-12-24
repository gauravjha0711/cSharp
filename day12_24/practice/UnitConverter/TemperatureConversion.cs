using System;
public class TemperatureConversion : UnitConverter
{
    // Temperature Conversions
    // •	Celsius to Fahrenheit:
    // F = (C × 9/5) + 32
    // •	Fahrenheit to Celsius:
    // C = (F − 32) × 5/9
    // •	Celsius to Kelvin:
    // K = C + 273.15
    // •	Kelvin to Celsius:
    // C = K − 273.15
    public override double Convert(double value, string fromUnit, string toUnit)
    {
        this.value = value;
        this.fromUnit = fromUnit.ToLower();
        this.toUnit = toUnit.ToLower();

        if (fromUnit == "celsius" && toUnit == "fahrenheit")
        {
            result = (value * 9 / 5) + 32;
        }
        else if (fromUnit == "fahrenheit" && toUnit == "celsius")
        {
            result = (value - 32) * 5 / 9;
        }
        else if (fromUnit == "celsius" && toUnit == "kelvin")
        {
            result = value + 273.15;
        }
        else if (fromUnit == "kelvin" && toUnit == "celsius")
        {
            result = value - 273.15;
        }
        else
        {
            throw new ArgumentException("Invalid conversion units for temperature.");
        }

        return result;
    }
    public override double Convert(double value, string fromUnit)
    {
        string defaultUnit = "celsius"; // Default unit for temperature
        return Convert(value, fromUnit, defaultUnit);
    }

}