using System.Collections.Generic;

namespace MyTechniques.Tests.Hard
{
    /// <summary>
    /// Approach: Two Heaps
    /// </summary>
    public class FindMedianFromDataStream
    {
        private readonly PriorityQueue<int, int> _minHeap;
        private readonly PriorityQueue<int, int> _maxHeap;

        public FindMedianFromDataStream()
        {
            _minHeap = new PriorityQueue<int, int>();
            _maxHeap = new PriorityQueue<int, int>(Comparer<int>.Create((x, y) => y - x));
        }

        public void AddNum(int num)
        {
            _minHeap.Enqueue(num, num);

            var minValue = _minHeap.Dequeue();
            _maxHeap.Enqueue(minValue, minValue);

            if (_minHeap.Count < _maxHeap.Count)
            {
                var maxValue = _maxHeap.Dequeue();
                _minHeap.Enqueue(maxValue, maxValue);
            }
        }

        public double FindMedian()
        {
            if (_minHeap.Count > _maxHeap.Count)
                return _minHeap.Peek();

            return (_minHeap.Peek() + _maxHeap.Peek()) / 2.0;
        }
    }
}