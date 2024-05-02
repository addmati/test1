namespace test1
{
    class Program
    {
        static int Sum(int[] arr)
        {

            int Sum = arr[0] + arr[1] + arr[2] + arr[3];


            return Sum;

        }

        static void Main(string[] args)
        {
            int[] ints = { 3, 6, 7, 9 };
            Console.WriteLine(Sum(ints));
        }
    }
}
