namespace MyTechniques.Tests.Others
{
    public class BinaryHeap
    {
        private readonly int[] _arr;
        private int _sizeOfTree;

        public BinaryHeap(int size)
        {
            //We are adding size+1, because array index 0 will be blank.
            _arr = new int[size + 1];
            _sizeOfTree = 0;
        }

        public int Peek()
        {
            if (_sizeOfTree == 0)
                return 0;
            else
                return _arr[1];
        }

        public int Size()
        {
            return _sizeOfTree;
        }
        public void Insert(int value)
        {
            if (_sizeOfTree < 0)
                return;

            _arr[_sizeOfTree + 1] = value;
            _sizeOfTree++;
            HeapifyBottomToTop(_sizeOfTree);
        }

        public void HeapifyBottomToTop(int index)
        {
            int parent = index / 2;
            // We are at root of the tree. Hence no more Heapifying is required.  
            if (index <= 1)
                return;

            // If Current value is smaller than its parent, then we need to swap  
            if (_arr[index] < _arr[parent])
            {
                int tmp = _arr[index];
                _arr[index] = _arr[parent];
                _arr[parent] = tmp;
            }
            HeapifyBottomToTop(parent);
        }
    }
}