namespace CommonPractises.ClassRecordStruct
{
    public class MainFunc
    {
        // Classes and structs are mutable
        // record are immutable

        // Records have automatic properties

        // A class can inherit from other classes, but a structure cannot.
        // In other words, a class can be derived from another class, but a structure cannot be.

        // A class is a reference type,
        // A structure, on the other hand, is a value type

        // A class always has a default constructor that is called when an object of the class is created.
        // A structure, on the other hand, does not have a default constructor by default.

        // Structures are usually smaller in size than classes because they do not contain any reference variables or overhead.
        // This means that structures can be faster to pass as parameters or to copy than classes.

        // All the classes are reference types are allocated on heap memory.
        // All the structs are value types are allocated on stack memory.
        // Records classes are reference types and record structs are value types

        // The data member of a class can be protected.
        // The data member of struct can’t be protected.

        // Function member of the class can be virtual or abstract.
        // Function member of the struct cannot be virtual or abstract.
    }
}
