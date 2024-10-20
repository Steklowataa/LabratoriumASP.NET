// namespace Calculator.Models;
// public class CalculatorModel
namespace Birth.Models;
public class BirthModel {

    public string Name {get; set;}
    public DateTime BirthDate {get; set;}

    public int CalculateAge(DateTime birthDate) {
        DateTime today = DateTime.Today;
        int age = today.Year - BirthDate.Year;

        return age;
    }
}