using System;
public class LengthConversion : UnitConverter
{
    // 1. Length Conversions
    // •	Meters to Kilometers:
    // 1 meter = 0.001 kilometers
    // •	Kilometers to Meters:
    // 1 kilometer = 1000 meters
    // •	Miles to Feet:
    // 1 mile = 5280 feet
    // •	Feet to Miles:
    // 1 foot = 1 / 5280 miles

    public override double Convert(double value, string fromUnit, string toUnit)
    {
        this.value = value;
        this.fromUnit = fromUnit.ToLower();
        this.toUnit = toUnit.ToLower();

        if (fromUnit == "meters" && toUnit == "kilometers")
        {
            result = value * 0.001;
        }
        else if (fromUnit == "kilometers" && toUnit == "meters")
        {
            result = value * 1000;
        }
        else if (fromUnit == "miles" && toUnit == "feet")
        {
            result = value * 5280;
        }
        else if (fromUnit == "feet" && toUnit == "miles")
        {
            result = value / 5280;
        }
        else
        {
            throw new ArgumentException("Invalid conversion units for length.");
        }

        return result;
    }

    public override double Convert(double value, string fromUnit)
    {
        string defaultUnit = "meters"; // Default unit for length
        return Convert(value, fromUnit, defaultUnit);
    }
}