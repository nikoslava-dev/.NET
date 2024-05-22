using System.Collections;
using System.Collections.Concurrent;

namespace CommonPractises.ConcurrentBag
{
    /// <summary>
    /// ConcurrentBag represent a group of objects that we may manipulate concurrently using multiple threads
    /// ConcurrentBag<T> is a generic collection type 
    /// It is a thread-safe collection that is suitable for scenarios where we want to add and remove items concurrently using multiple threads.
    /// When we use this collection type, the order in which we add items to our collection, may not be the same as when we retrieve them.
    /// use a ConcurrentBag when we have multiple threads that need to add or remove items from a collection concurrently.
    /// </summary>
    public class MainBag
    {
        public void RunProcess()
        {
            ConcurrentBag<int> myNumbers = new();

            // We initialize a ConcurrentBag that doesn’t have a specified capacity.
            // Its size can increase or decrease dynamically depending on the operations that we perform on it.
            // Also, we can iterate through this collection using a foreach loop.
            var concurrentBag1 = new ConcurrentBag<int>() { 2, 4, 6, 8, 10 };

            //It is important to note that the data type of the collection we pass in, must be the same as the type of ConcurrentBag.
            var myList = new List<int>() { 1, 2, 3, 4, 5, 6, 7 };
            var concurrentBag2 = new ConcurrentBag<int>(myList);

            ConcurrentBag<int> concurrentBag3 = CreateAndAddToConcurrentBagConcurrently();

            //  the order of removing items from the collection, may not be the same as the order of adding items.
            ArrayList list1 = RemoveFromConcurrentBag(concurrentBag3);

            ConcurrentBag<int> concurrentBag4 = CreateAndAddToConcurrentBagConcurrently();
            ArrayList list2 = RemoveFromConcurrentBagConcurrently(concurrentBag4);

            ConcurrentBag<int> concurrentBag5 = CreateAndAddToConcurrentBagConcurrently();
            ArrayList list3 = AccessItemFromAConcurrentBag(concurrentBag5);


            ConcurrentBag<int> concurrentBag6 = CreateAndAddToConcurrentBagConcurrently();
            ArrayList list4 = AccessItemFromAConcurrentBagConcurrently(concurrentBag6);
        }

        #region create

        // Parallel.For method to execute a loop concurrently, with each iteration running on a separate thread.
        public ConcurrentBag<int> CreateAndAddToConcurrentBagConcurrently()
        {
            ConcurrentBag<int> numbersBag = new();
            Parallel.For(0, 1000, i =>
            {
                numbersBag.Add(i);
            });
            return numbersBag;
        }

        #endregion

        #region remove
        // when we remove an item from the ConcurrentBag
        public ArrayList RemoveFromConcurrentBag(ConcurrentBag<int> numbersBag)
        {
            var result = new ArrayList();
            if (numbersBag.TryTake(out int number))
            {
                result.Add(number);
            }
            return result;
        }

        //Parallel.For method to execute a loop concurrently, with each iteration running on a separate thread.
        public ArrayList RemoveFromConcurrentBagConcurrently(ConcurrentBag<int> bag)
        {
            var numbersList = new ArrayList();
            Parallel.For(0, 20, i =>
            {
                if (bag.TryTake(out int number))
                {
                    Console.WriteLine($"Thread {Environment.CurrentManagedThreadId} took item: {number}");
                    numbersList.Add(number);
                }
            });
            return numbersList;
        }

        #endregion

        #region access

        // it returns an item from the collection but does not remove it
        public ArrayList AccessItemFromAConcurrentBag(ConcurrentBag<int> bag)
        {
            var result = new ArrayList();
            if (bag.TryPeek(out int number))
            {
                result.Add(number);
            }
            return result;
        }

        public ArrayList AccessItemFromAConcurrentBagConcurrently(ConcurrentBag<int> bag)
        {
            var numbersList = new ArrayList();
            Parallel.For(0, 50, i =>
            {
                if (bag.TryPeek(out int number))
                {
                    Console.WriteLine("Thread {0} peeked item: {1}", Environment.CurrentManagedThreadId, number);
                    numbersList.Add(number);
                }
            });
            return numbersList;
        }

        #endregion
    }
}
