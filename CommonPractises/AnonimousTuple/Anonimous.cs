namespace CommonPractises.AnonimousTuple
{
    public class Anonimous
    {
        public void RunProcess1()
        {
            var dates = new[]
            {
                DateTime.UtcNow.AddHours(-1),
                DateTime.UtcNow,
                DateTime.UtcNow.AddHours(1),
            };

            foreach (var anonymous in
                         dates.Select(
                             date => new { Formatted = $"{date:MMM dd, yyyy hh:mm zzz}", date.Ticks }))
            {
                Console.WriteLine($"Ticks: {anonymous.Ticks}, formatted: {anonymous.Formatted}");
            }

            /* Open assemply result
                 * internal sealed class f__AnonymousType0
                {
                    public string Formatted { get; }
                    public long Ticks { get; }

                    public f__AnonymousType0(string formatted, long ticks)
                    {
                        Formatted = formatted;
                        Ticks = ticks;
                    }
                }*/
        }

        public void RunProcess2(object context)
        {
            var persons = from person in context.Persons
                          select new { Name = person.Name, Age = person.Age };

            // Having this anonymous type in our context means that we could write person.
            // Name to get the value of the Name variable.
            // One thing that is important when talking about anonymous types is that the variables are read only,
            // anonymous type are immutable. you can change anonymous type by create new anonymous type base on another anonymous type with different property values.
            // which means that you cannot change Name after you've initialized the anonymous type.
        }
    }
}
