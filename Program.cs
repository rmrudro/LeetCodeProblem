// See https://aka.ms/new-console-template for more information


//int numberRef=10 ;

//Console.WriteLine($"Before calling the ChangeRef method the numberRef is {numberRef}");
//ConsoleApp1.RefOutClass.ChangeRef(ref numberRef);
//Console.WriteLine($"After calling the ChangeRef method the numberRef is {numberRef}");
//Console.WriteLine();
//int numberOut;
//Console.WriteLine("Before calling the ChangeOut method the numberOut is unassigned");
//ConsoleApp1.RefOutClass.ChangeOut(out numberOut);
//Console.WriteLine($"After calling the ChangeOut method the numberOut is {numberOut}");
//Console.ReadKey();
namespace ConsoleApp1
{
    public class RefOutClass
    {

        static void Main()
        {
            int[] numbers = new int[8] { 5, 6, 4, 1, 8, 2, 3, 0 };


            Console.WriteLine("Before:");
            PrintArray(numbers);

            MergeSort(numbers);

            Console.WriteLine("\nAfter:");
            PrintArray(numbers);

        }

        private static void MergeSort(int[] numbers)
        {
            int length = numbers.Length;

            if (length < 2)
            {
                return;
            }

            int midindex = (length) / 2;
            int[] leftarray = new int[midindex];
            int[] rightarray = new int[length - midindex];

            for (int i = 0; i < midindex; i++)
            {
                leftarray[i] = numbers[i];
            }
            for (int i = midindex; i < length; i++)
            {
                rightarray[i - midindex] = numbers[i];
            }

            MergeSort(leftarray);
            MergeSort(rightarray);

            Merge(numbers, leftarray, rightarray);

        }

        private static void Merge(int[] fullarray, int[] leftarray, int[] rightarray)
        {
            int leftsize = leftarray.Length;
            int rightsize = rightarray.Length;
            int i = 0, j = 0, k = 0;


            while (i < leftsize && j < rightsize)
            {
                if (leftarray[i] < rightarray[j])
                {
                    fullarray[k] = leftarray[i];
                    i++;
                }
                else
                {
                    fullarray[k] = rightarray[j];
                    j++;
                }
                k++;
            }
            while (i < leftsize)
            {
                fullarray[k] = leftarray[i];
                i++;
                k++;
            }
            while (j < rightsize)
            {
                fullarray[k] = rightarray[j];
                j++;
                k++;
            }

        }

        private static void PrintArray(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }
    }
}

