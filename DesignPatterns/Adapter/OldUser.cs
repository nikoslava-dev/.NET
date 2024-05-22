namespace DesignPatterns.Adapter
{
    public class OldUser
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public void PrintOldUser()
        {
            Console.WriteLine($"User id: {Id}");
            Console.WriteLine($"User Name: {Name}");
        }
    }
}
