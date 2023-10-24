namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Non generics
            // ArrayList
            //ArrayList arrayList = new ArrayList();

            //arrayList.Add(55);
            //arrayList.Add("Elsever");
            //arrayList.Add(new Teacher { Fullname = "Eli Veliyev" });


            //arrayList.RemoveAt(0);

            //arrayList.Clear();
            //Console.WriteLine(arrayList.Count);

            //Console.WriteLine(arrayList[0]);
            //foreach (var item in arrayList)
            //{
            //    if (item is Teacher)
            //    {
            //        Teacher teacher = (Teacher)item;
            //        Console.WriteLine(teacher.Fullname);
            //    }
            //    else
            //    {
            //        Console.WriteLine(item);
            //    }
            //}


            //SortedList

            //SortedList sortedList = new SortedList();

            //sortedList.Add(88.8, "Ulker");
            //sortedList.Add(89.9, 99);



            //foreach (DictionaryEntry item in sortedList)
            //{
            //    Console.WriteLine(item.Key + " " + item.Value);
            //}

            // Queue
            //Queue queue = new Queue();
            //queue.Enqueue(1);
            //queue.Enqueue(13);
            //queue.Enqueue(18);

            //Console.WriteLine("Peek:");
            //Console.WriteLine(queue.Peek());
            //Console.WriteLine("Dequeue");
            //Console.WriteLine(queue.Dequeue());
            //Console.WriteLine("Peek:");
            //Console.WriteLine(queue.Peek());
            //Console.WriteLine(queue.Dequeue());
            //Console.WriteLine("Queue:");
            //foreach (var item in queue)
            //{
            //    Console.WriteLine(item);
            //}


            // Stack
            //Stack stack = new Stack();

            //stack.Push(11);
            //stack.Push(132);
            //stack.Push(185);

            //Console.WriteLine("Peek:");
            //Console.WriteLine(stack.Peek());
            //Console.WriteLine("Pop:");
            //Console.WriteLine(stack.Pop());
            //Console.WriteLine("Stack: ");
            //foreach (var item in stack)
            //{
            //    Console.WriteLine(item);
            //}


            // Hashtable

            //Hashtable hashtable = new Hashtable();

            //hashtable.Add(1, "Elsever");
            //hashtable.Add(2, "Ulker");

            //Console.WriteLine("Hashtable");
            //foreach (DictionaryEntry item in hashtable)
            //{
            //    Console.WriteLine(item.Key + "  " + item.Value);
            //}
            #endregion

            #region Generics
            List<int> ints = new List<int>()
            {
                1,2,3
            };

            Console.WriteLine(ints.Capacity);

            ints.Add(95);
            Console.WriteLine(ints.Capacity);

            ints.Add(77);
            Console.WriteLine(ints.Capacity);
            ints.Add(77);
            Console.WriteLine(ints.Capacity);


            //Console.WriteLine(ints.Count);

            //foreach (var item in ints)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion
        }
    }
}