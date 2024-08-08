namespace ConsoleAppDelegateQuestion2
{

    //delegate
    public delegate int[] ArrayDeligate(int[] array);
    public class Program

    {

        static void Main(string[] args)

        {

            //creating object for class
            Program obj = new Program();

            Console.WriteLine("The application to reverse or sort Array");
            //getting input from user
            Console.WriteLine("Enter the size of the array:");
            int length = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the elements in the array");
            int[] arr = new int[length];

            //for loop
            for (int i = 0; i < length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());

            }

            //deligate
            ArrayDeligate delegateArray = new ArrayDeligate(obj.Sort);

            //getting input from user
            Console.WriteLine("Choose any option\n 1.Sort\n 2.Reverse");
            Console.WriteLine("Enter the option");
            int option = int.Parse(Console.ReadLine());
            if (option == 1)
            {


                delegateArray.Invoke(arr);

            }
            else if (option == 2)
            {

                delegateArray += obj.Reverse;
                delegateArray -= obj.Sort;
                delegateArray.Invoke(arr);
            }

        }

        //sort method
        public int[] Sort(int[] arr)
        {

            Array.Sort(arr);
            foreach (int number in arr)
            {
                Console.WriteLine(number);
            }
            return arr;
        }

        //reverse method
        public int[] Reverse(int[] arr)
        {
            Array.Reverse(arr);
            foreach (int number in arr)
            {
                Console.WriteLine(number);
            }


            return arr;
        }
    }


}
