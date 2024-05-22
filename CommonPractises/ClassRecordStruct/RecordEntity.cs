namespace CommonPractises.ClassRecordStruct
{
    public class Main
    {
        public void RunProcess()
        {
            PersonC person1 = new PersonC("Alice", "ssssssssss");

            Console.WriteLine($"Person - Name: {person1.FirstName}, LastName: {person1.LastName}");

            // Use the with expression to create a new instance with modified properties
            PersonC modifiedPerson = person1 with { FirstName = "Bob", LastName = "gggggggggggggggg" };

            Console.WriteLine($"Modified Person - Name: {modifiedPerson.FirstName}, LastName: {modifiedPerson.LastName}");

            PersonClass person2 = new PersonClass { FirstName = "dddddddd", LastName = "dfsdfsddfs" };
            Console.WriteLine($"Modified Person 2 - Name: {person2.FirstName}, LastName: {person2.LastName}");





            PersonS person3 = new PersonS("rrrrrr", "mmmmmm");

            PersonStruct person4 = new PersonStruct { FirstName = "rrrrrr", LastName = "mmmmmm" };

        }
    }

    public record PersonC(string FirstName, string LastName);

    public record PersonClass
    {
        public required string FirstName { get; init; }
        public required string LastName { get; init; }
    };


    /// <summary>
    /// A record or a record class declares a reference type. 
    /// The class keyword is optional, but can add clarity for readers. A record struct declares a value type.
    /// Positional properties are immutable in a record class and a readonly record struct. 
    /// They're mutable in a record struct.
    /// </summary>
    /// <param name="FirstName"></param>
    /// <param name="LastName"></param>
    public readonly record struct PersonS(string FirstName, string LastName);

    public record struct PersonStruct
    {
        public string FirstName { get; init; }
        public string LastName { get; init; }
    }
}
