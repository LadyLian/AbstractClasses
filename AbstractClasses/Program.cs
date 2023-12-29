namespace AbstractClasses
{
    internal class Program
    {
        public static int number;
        public static int[] arr;
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of elements in the array: ");
            var IsNumber = int.TryParse(Console.ReadLine(), out int number);
            if (IsNumber == false)
            {
                throw new Exception("Sorry, enter the number!");
            }
            arr = new int[number];
            Console.WriteLine(arr.Length);
            Random rnd = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(0,100);
            }
            MyArray array = new MyArray();
            array.Show(arr);
            array.Show("It`s the message!",arr);
        }
    }
}