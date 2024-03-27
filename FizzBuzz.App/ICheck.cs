namespace FizzBuzz.App
{
    public interface ICheck
    {
        string GetResponse();
        bool Validate(int number);
    }
}