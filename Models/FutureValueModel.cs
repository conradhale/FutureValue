using System.ComponentModel.DataAnnotations;

namespace FutureValue.Models;

public class FutureValueModel
{
    [Required(ErrorMessage = "Please enter a monthly investment.")]
    [Range(1, 500, ErrorMessage = "Monthly investment amount must be between 1 and 500.")]
    public double MonthlyInvestment { get; set; } = 0;

    [Required(ErrorMessage = "Please enter a yearly interest rate.")]
    [Range(0.1, 25.0, ErrorMessage = "Yearly interest rate must be between 0.1 and 10.0.")]
    public double YearlyInterestRate { get; set; } = 0;

    [Required(ErrorMessage = "Please enter a number of years.")]
    [Range(1, 50, ErrorMessage = "Number of years must be between 1 and 50.")]
    public int Years { get; set; } = 0;

    public string FutureValue = 0.ToString("C2");
}
