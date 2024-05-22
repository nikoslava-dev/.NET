namespace CommonPractises.AnonimousTuple
{
    public class Tuple
    {
        /// <summary>
        /// With the System.Tuple<T1,T2>, the instance exposes numbered item properties, such as Item1, and Item2. 
        /// These property names can make it more difficult to understand the intent of the property values, as the property name only provides the ordinal. 
        /// Furthermore, the System.Tuple types are reference class types.
        /// </summary>
        public void Example1()
        {
            var dates = new[]
            {
                DateTime.UtcNow.AddHours(-1),
                DateTime.UtcNow,
                DateTime.UtcNow.AddHours(1),
            };

            foreach (var tuple in
                        dates.Select(
                            date => new Tuple<string, long>($"{date:MMM dd, yyyy hh:mm zzz}", date.Ticks)))
            {
                Console.WriteLine($"Ticks: {tuple.Item2}, formatted: {tuple.Item1}");
            }
        }

        /// <summary>
        /// The System.ValueTuple<T1,T2> however, is a value struct type. 
        /// The following C# snippet, uses ValueTuple<string, long> to project into.
        /// This examples are all functionally equivalent, however, there are slight differences in their usability and their underlying implementations.
        /// </summary>
        public void Example2()
        {
            var dates = new[]
            {
                DateTime.UtcNow.AddHours(-1),
                DateTime.UtcNow,
                DateTime.UtcNow.AddHours(1),
            };

            foreach (var (formatted, ticks) in
                        dates.Select(
                            date => (Formatted: $"{date:MMM dd, yyyy at hh:mm zzz}", date.Ticks)))
            {
                Console.WriteLine($"Ticks: {ticks}, formatted: {formatted}");
            }
        }
    }
}
