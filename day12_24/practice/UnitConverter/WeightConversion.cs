using System;
public class WeightConversion : UnitConverter
{
    // Weight Conversions
    // •	Grams to Kilograms:
    // 1 gram = 0.001 kilograms
    // •	Kilograms to Grams:
    // 1 kilogram = 1000 grams
    // •	Pounds to Ounces:
    // 1 pound = 16 ounces
    // •	Ounces to Pounds:
    // 1 ounce = 1 / 16 pounds
    public override double Convert(double value, string fromUnit, string toUnit)
    {
        this.value = value;
        this.fromUnit = fromUnit.ToLower();
        this.toUnit = toUnit.ToLower();

        if (fromUnit == "grams" && toUnit == "kilograms")
        {
            result = value * 0.001;
        }
        else if (fromUnit == "kilograms" && toUnit == "grams")
        {
            result = value * 1000;
        }
        else if (fromUnit == "pounds" && toUnit == "ounces")
        {
            result = value * 16;
        }
        else if (fromUnit == "ounces" && toUnit == "pounds")
        {
            result = value / 16;
        }
        else
        {
            throw new ArgumentException("Invalid conversion units for weight.");
        }

        return result;
    }
    public override double Convert(double value, string fromUnit)
    {
        string defaultUnit = "kilograms"; // Default unit for weight
        return Convert(value, fromUnit, defaultUnit);
    }
}