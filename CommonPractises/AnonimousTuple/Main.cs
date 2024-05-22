namespace CommonPractises.AnonimousTuple
{
    public class Main
    {
        public void RunProcess()
        {
            // Anonymous types have property names which carry more information, for tuples you don't have this.
            // You can't use anonymous types as return values and parameters though and you can with tuples.

            // You might want to always use ValueTuple over Tuple, and anonymous types, but there are tradeoffs you should consider.
            // The ValueTuple types are mutable, whereas Tuple are read-only.
            // Anonymous types can be used in expression trees, while tuples cannot.
            // The following table is an overview of some of the key differences.

            // Name                 Access modifier         Type            Custom member name          Deconstruction support  
            // Anonymous types      internal                class           ✔️	                            ❌	
            // Tuple                public                  class           ❌	                            ❌	
            // ValueTuple           public                  struct          ✔️	                            ✔️	

            // Serialization is the process of converting the state of an object into a form that can be persisted or transported.
            // When serialization is important, creating a class or struct is preferred over anonymous types or tuple types.

            // Performance major impact involves the tradeoff between allocations and copying. In most scenarios, the impact is small.
        }
    }
}
