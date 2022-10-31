using System;


namespace BinarySeacrh
{
    class program
    {
        int[] arr = new int[26];
        int n;
        int i;

        public void input()
        {
            while (true)
            {
                Console.Write("Enter the number of elements in the array: ");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if ((n > 0) && (n <= 20))
                    break;
                else
                    Console.WriteLine("\nArray should have minimum 1 and maximum 20 elements.\n");
            }
            for (i = 0; i < n; i++)
            {
                Console.Write("<" + (i + 1) + ">");
                string s1 = Console.ReadLine();
                arr[i] = Int32.Parse(s1);
            }
        }
        public void BinarySeacrh()
        {
            char ch;
            do
            {
                Console.Write("\nEnter element want you to search :");
                int item = Convert.ToInt32(Console.ReadLine());

                int lowerbound = 0;
                int upperbound = n - 1;

                int mid = (lowerbound + upperbound) / 2;
                int ctr = 1;

                while ((item != arr[mid]) && (lowerbound <= upperbound))
                {
                    if (item > arr[mid])
                        lowerbound = mid + 1;
                    else
                        upperbound = mid - 1;
                    mid = (lowerbound + upperbound) / 2;
                    ctr++;
                }
                if (item == arr[mid])
                    Console.WriteLine("\n" + item.ToString() + " found at position " + (mid + 1).ToString());
                else
                    Console.WriteLine("\n" + item.ToString() + " not found in the array\n");
                Console.WriteLine("\nNumber of comparasion : " + ctr);

                Console.Write("\nContinue search (y/n):");
                ch = char.Parse(Console.ReadLine());

            } while ((ch == 'y') || (ch == 'Y'));
        }
        static void Main(string[] args)
        {
            program mylist = new program();

            mylist.input();

            mylist.BinarySeacrh();

            Console.WriteLine("\n\n Tekan tombol apa saja untuk keluar.");
            Console.Read();
        }
    }
}