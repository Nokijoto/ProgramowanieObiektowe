namespace Laboratorium_2_20_10_2022.Services.Lab5
{
    public class SomeClass
    {
        public string Print(string SomeText)
        {
            try
            {
                return SomeText.Length.ToString();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw new EmployeeListNotFoundException("Custom Exception fired");
            }
            

        }
    }
}
