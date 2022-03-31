using System.Collections.Generic;

namespace MyTechniques.Tests
{
    public class DataStructures
    {
        public DataStructures()
        {
            // 1) Simple Array
            // Most efficient use of memory; use in cases where data size is fixed.
            var arr = new int[3];
            arr[0] = 1;
            arr[1] = 2;
            arr[2] = 3;

            // 2) Multi Array of 2D
            // Most efficient use of memory; use in cases where data size is fixed.
            var matrix = new int[3, 2];
            matrix[0, 0] = 1;
            matrix[0, 1] = 10;
            matrix[1, 0] = 2;
            matrix[1, 1] = 20;
            matrix[2, 0] = 3;
            matrix[2, 1] = 30;

            // 3) Multiple Array with Dynamic Size
            // Most efficient use of memory; use in cases where data size is fixed.
            var multiArr = new int[3][];
            multiArr[0] = new int[] { 1 };
            multiArr[1] = new int[] { 1, 2 };
            multiArr[2] = new int[] { 1, 2, 3 };

            // 4) Dynamic Array
            // Implementation is optimized for speed. In many cases, List will be the best choice.
            var x = new List<int>(arr);
            var list = new List<int>();
            list.Add(1); // best case O(1) or worst case O(N)
            list.Add(5);
            list.Add(2);
            list.Add(4);
            list.Add(3);

            // 5) Double Linked List
            // Many operations are fast, but watch out for cache coherency.
            var linkedList = new LinkedList<int>();
            linkedList.AddFirst(1); // O(1)
            linkedList.AddFirst(2);
            linkedList.AddFirst(3);
            linkedList.AddFirst(9);
            linkedList.AddFirst(5);
            linkedList.AddFirst(6);
            linkedList.AddFirst(10);
            linkedList.AddFirst(7);

            // 6) HashSet
            // Unique elements
            // No ordered elements
            var set = new HashSet<int>();
            set.Add(13); // O(1)
            set.Add(2);
            set.Add(3);

            // 7) SortedSet
            // Unique elements
            // Ordered elements
            var sortedSet = new SortedSet<int>();
            sortedSet.Add(13); // O(1)
            sortedSet.Add(2);
            sortedSet.Add(3);

            // 8) SortedList
            // Use key-value pair
            // Ordered elements
            var sortedList = new SortedList<string, int>();
            sortedList.Add("3a", 1); // best case O(1) or worst case O(N)
            sortedList.Add("2c", 3);
            sortedList.Add("1b", 5);
            sortedList.ContainsKey("3a");
            sortedList.ContainsValue(1);

            // 9) HashMap
            // Use key-value pair
            // No ordered elements
            var dic = new Dictionary<string, int>();
            dic.Add("a", 1); // best case O(1) or worst case O(N)
            dic.Add("c", 3);
            dic.Add("b", 2);

            // 10) SortedDictionary
            // Use key-value pair
            // Ordered elements
            var sortedDictionary = new SortedDictionary<string, int>();
            sortedDictionary.Add("a", 1);
            sortedDictionary.Add("c", 3);
            sortedDictionary.Add("b", 2);

            // 11) Stack(LIFO)
            // Shouldn't be selected for performance reasons, but algorithmic ones.
            var stack = new Stack<int>();
            stack.Push(1); // best case O(1) or worst case O(N)
            stack.Push(2);
            stack.Push(3);
            var topElement = stack.Pop();
            var newTopElement = stack.Peek();

            // 12) Queue(FIFO)
            var queue = new Queue<int>();
            queue.Enqueue(1); // best case O(1) or worst case O(N)
            queue.Enqueue(2);
            queue.Enqueue(3);
            var first = queue.Dequeue();
            var newFirst = queue.Peek();

            // 13) Prioriry Queue
            var heapMin = new PriorityQueue<string, int>();
            heapMin.Enqueue("a", 2); // O(log n)
            heapMin.Enqueue("b", 3);
            heapMin.Enqueue("c", 1);

            // 14) Priority Queueu Customized for the max value priority
            var heapMax = new PriorityQueue<int, int>(Comparer<int>.Create((x, y) => y - x));
            heapMax.Enqueue(100, 1); // O(log n)
            heapMax.Enqueue(10, 2);
            heapMax.Enqueue(50, 3);

            var heapMaxString = new PriorityQueue<object, int>(Comparer<int>.Create((x, y) => y - x));
            heapMaxString.Enqueue("a", 1); // O(1)
            heapMaxString.Enqueue("b", 2);
            heapMaxString.Enqueue("c", 3);

            // 15) 
            var linkedListNode = new LinkedListNode<int>(0);
            linkedListNode.Value = 1;
            //linkedListNode.Next = new LinkedListNode<int>(2);
        }
    }
}