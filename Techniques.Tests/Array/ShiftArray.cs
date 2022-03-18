namespace Techniques.Tests.Array
{
    public class ShiftArray
    {
        public void ShiftToRight(int num, int pos, int[] arr)
        {
            if (pos < 0 || pos >= arr.Length)
                return;

            var n = arr.Length;

            for (int i = n-1; i > pos; i--)
                arr[i] = arr[i-1];

            arr[pos] = num;
        }

        public void ShiftToLeft(int num, int pos, int[] arr)
        {
            if (pos < 0 || pos >= arr.Length)
                return;

            var n = arr.Length;

            for (int i = 0; i < pos; i++)
                arr[i] = arr[i + 1];

            arr[pos] = num;
        }

        //public void Shift(int num, int pos, int[] arr)
        //{
        //    if (pos < 0 || pos >= arr.Length)
        //        return;

        //    var n = arr.Length;

        //    for (int i = 0; i < pos; i++)
        //        arr[(i + 1) % n] = arr[i];
        //}
    }
}