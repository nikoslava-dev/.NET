namespace DesignPatterns.Disposable
{
    /// <summary>
    /// All primitive variables go onto stack that is part of this heap and the objects go directly onto this heap. 
    /// Therefore, when we say primitive variables are located on stack and objects on the heap, we are actually not correct. 
    /// They are all on heap, in particular, the managed heap of the belonging process but primitive variables go to a specific area of that heap that is organized as a stack.
    /// GC tracks memory on managed heap
    /// heap and heap is organized into small-objects heap and large-objects heap. 
    /// Small heap objects are typically your object instances whereas large heap objects are typically larger objects such as arrays. 
    /// Heap is also further segmented into segments or generations for easier handling of short and long lived objects.
    /// 
    /// implement finalizer method to release unmanaged resources
    /// This method is only called by the garbage collector which is initialized by the CLR
    /// instead you implement destructor method
    /// GC frequently checks this generation for unused objects, it will also detect if your objects have implemented finalizer (and are therefore finalizable) and if so, 
    /// its finalizer is placed into yet another area of the managed heap. That area is called finalize queue
    /// 
    /// we never know when the garbage collector will clean up memory. We have no power over it, and we can not rely on it
    /// </summary>
    public class ImplementaionClass
    {
        public void RunProcess()
        {
            // using distroy object in finaly. new() = new Car()
            using CarOptional car = new();
        }
    }
}
