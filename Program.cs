internal class Program
{
    private static void Main(string[] args)
    {

        Console.WriteLine("Enter your height : ");
        var height = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter your weight : ");
        var weight = Convert.ToDouble(Console.ReadLine());


        var bmi = weight / Math.Pow(height, 2);


        string result;
        if (bmi < 18.5)
        {
            result = "UnderWeight";
        }
        else if (bmi >= 18.5 && bmi <= 24.9)
        {
            result = "Normal Range";
        }
        else if (bmi >= 25 && bmi <= 29.9)
        {
            result = "Overweight";
        }
        else
        {
            result = "Obese";
        }

        Console.WriteLine("Your status is : " + result);

    }
}