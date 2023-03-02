namespace AlgorithmPracticeProblemm
{
    class Program
    {
        public static void Main(string[] args) 
        {
            Console.WriteLine("Welcome to Algorithm Programs");
            //Anagram anagram = new Anagram();
            //anagram.DispayAnagram();
            //BubbleSort bubbleSort= new BubbleSort();
            //bubbleSort.DisplayNumbers();
            //InsertionSort insertionSort = new InsertionSort();
            //insertionSort.DisplayNumbers();
            int[] arr = { 8, 4, 21, 88, 45, 125, 12 };

            Console.WriteLine("Array before sorting:");
            MergeSort.PrintArray(arr);

            MergeSort.mergeSort(arr, 0, arr.Length - 1);

            Console.WriteLine("\nArray after Merge sort:");
            MergeSort.PrintArray(arr);

        }
    }
}