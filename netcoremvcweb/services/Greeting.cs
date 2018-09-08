namespace netcoremvcweb.services
{
    public interface IGreeting
    {
        string GetGreetings();
    }

    public class GreetingService : IGreeting
    {
        public string GetGreetings()
        {
            return "Hello from greeting service";
        }
    }
}
