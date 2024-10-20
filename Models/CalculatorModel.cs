namespace Calculator.Models;
public class CalculatorModel
{
    public string? operation { get; set; }
    public double? numberX { get; set; }
    public double? numberY { get; set; }

    public String Op
    {
        get
        {
            switch (operation)
            {
                case "add":
                    return "+";
                case "subtract":
                    return "-";
                case "multiply":
                    return "*";
                case "divide":
                    return "/";
                default:
                    return "";
            }
        }
    }

    public bool IsValid()
    {
        return operation != null && numberX != null && numberY != null;
    }

    public double Calculate() {
        switch (operation)
        {
            case "add":
                return (double) (numberX + numberY);
            case "subtract":
                return (double) (numberX - numberY);
            case "multiply":
                return (double) (numberX * numberY);
              case "divide":
                return (double) (numberX / numberY);
            default: return double.NaN;
        }
    }
}
