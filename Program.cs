using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Labs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] tasks = new string[33]
            {
                "1. A[0], A[2], A[4], ...",
                "2. Print paired elements",
                "3. Number of positive elements",
                "4. Number of items larger than the previous one",
                "5. Are there two elements with the same characters",
                "6. The number of elements of both neighbors",
                "7. Rearrange the items in reverse order",
                "8. Rearrange adjacent items",
                "9. Cyclic shift to the right",
                "10. Maximum in the array",
                "11. The number of different elements in a monotone array",
                "12. Rank",
                "13. Double coup",
                "14. Super shift",
                "15. Balls",
                "16. Side diagonal",
                "17. Or a symmetric matrix",
                "18. Competition",
                "19. Competitions - 2",
                "20. Competitions - 3 ",
                "21. Competitions - 4",
                "22. Competitions - 5",
                "23. Multiplication table",
                "24. Pascal's triangle",
                "25. Spiral filling",
                "26. Filling with a snake",
                "27. Filling wit diagonals",
                "28. Engineer",
                "29. Revolution",
                "30. Spiral",
                "31. Julian calendar",
                "32. Day after tomorrow",
                "33. Number of days from the beginning of the era",
            };

            foreach (string n in tasks)
            {
                Console.WriteLine(n);
            }

            Console.WriteLine();
            Console.WriteLine("Choose task number:");
            int taskNumber = Convert.ToInt32(Console.ReadLine());

            switch (taskNumber)
            {
                case 1:
                    task1();
                    break;
                case 2:
                    task2();
                    break;
                case 3:
                    task3();
                    break;
                case 4:
                    task4();
                    break;
                case 5:
                    task5();
                    break;
                case 6:
                    task6();
                    break;
                case 7:
                    task7();
                    break;
                case 8:
                    task8();
                    break;
                case 9:
                    task9();
                    break;
                case 10:
                    task10();
                    break;
                case 11:
                    task11();
                    break;
                case 12:
                    //
                    break;
                case 13:
                    //
                    break;
                case 14:
                    //
                    break;
                case 15:
                    //
                    break;
                case 16:
                    //
                    break;
                case 17:
                    //
                    break;
                case 18:
                    //
                    break;
                case 19:
                    //
                    break;
                case 20:
                    //
                    break;
                case 21:
                    //
                    break;
                case 22:
                    //
                    break;
                case 23:
                    //
                    break;
                case 24:
                    //
                    break;
                case 25:
                    //
                    break;
                case 26:
                    //
                    break;
                case 27:
                    //
                    break;
                case 28:
                    //
                    break;
                case 29:
                    //
                    break;
                case 30:
                    //
                    break;
                case 31:
                    //
                    break;
                case 32:
                    //
                    break;
                case 33:
                    //
                    break;
                default:
                    Console.WriteLine("Invalid input!");
                    break;
            }

        }

        static void task1()
        {
            Console.WriteLine("Write array size:");
            int arrSize = Convert.ToInt32(Console.ReadLine());

            while(arrSize < 1 || arrSize > 100)
            {
                Console.WriteLine("Incorrect value! Array size must be from 1 to 100. Try again:");
                arrSize = Convert.ToInt32(Console.ReadLine());
            }

            int[] arr = new int[arrSize];

            Console.WriteLine("Input array elements (use 1 string and space):");
            string elements = Console.ReadLine();

            arr = elements.Trim().Split(' ').Select(x => int.Parse(x)).ToArray();

            int i = 0;

            Console.WriteLine("Output:");
            for(i=0; i<arrSize; i++)
            {
                if (i%2 == 0)
                {
                    Console.WriteLine(arr[i]);
                }
            }

            Console.ReadLine();
        }

        static void task2()
        {
            Console.WriteLine("Write array size:");
            int arrSize = Convert.ToInt32(Console.ReadLine());

            while (arrSize < 1 || arrSize > 100)
            {
                Console.WriteLine("Incorrect value! Array size must be from 1 to 100. Try again:");
                arrSize = Convert.ToInt32(Console.ReadLine());
            }

            int[] arr = new int[arrSize];

            Console.WriteLine("Input array elements (use 1 string and space):");
            string elements = Console.ReadLine();

            int i = 0;
            arr = elements.Trim().Split(' ').Select(x => int.Parse(x)).ToArray();

            Console.WriteLine("Output:");
            for (i = 0; i < arrSize; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    Console.WriteLine(arr[i]);
                }
            }

            Console.ReadLine();
        }

        static void task3()
        {
            Console.WriteLine("Write array size:");
            int arrSize = Convert.ToInt32(Console.ReadLine());

            while (arrSize < 1 || arrSize > 10000)
            {
                Console.WriteLine("Incorrect value! Array size must be from 1 to 10000. Try again:");
                arrSize = Convert.ToInt32(Console.ReadLine());
            }

            int[] arr = new int[arrSize];

            Console.WriteLine("Input array elements (use 1 string and space):");
            string elements = Console.ReadLine();

            int i = 0;
            arr = elements.Trim().Split(' ').Select(x => int.Parse(x)).ToArray();

            Console.WriteLine("Output:");
            int count = 0;
            for (i = 0; i < arrSize; i++)
            {
                if (arr[i] >= 0)
                {
                    count++;
                }
            }

            Console.WriteLine(count);
            Console.ReadLine();
        }

        static void task4()
        {
            Console.WriteLine("Write array size:");
            int arrSize = Convert.ToInt32(Console.ReadLine());

            while (arrSize < 1 || arrSize > 10000)
            {
                Console.WriteLine("Incorrect value! Array size must be from 1 to 10000. Try again:");
                arrSize = Convert.ToInt32(Console.ReadLine());
            }

            int[] arr = new int[arrSize];

            Console.WriteLine("Input array elements (use 1 string and space):");
            string elements = Console.ReadLine();

            int i = 0;
            arr = elements.Trim().Split(' ').Select(x => int.Parse(x)).ToArray();

            Console.WriteLine("Output:");
            int count = 0;
            for (i = 1; i < arrSize; i++)
            {
                if (arr[i] > arr[i-1])
                {
                    count++;
                }
            }

            Console.WriteLine(count);
            Console.ReadLine();
        }

        static void task5()
        {
            Console.WriteLine("Write array size:");
            int arrSize = Convert.ToInt32(Console.ReadLine());

            while (arrSize < 1 || arrSize > 10000)
            {
                Console.WriteLine("Incorrect value! Array size must be from 1 to 10000. Try again:");
                arrSize = Convert.ToInt32(Console.ReadLine());
            }

            int[] arr = new int[arrSize];
            Boolean validString = true;
            int i = 0;

            Console.WriteLine("Input array elements (use 1 string and space). Element can't be equal 0:");
            string elements = Console.ReadLine();

            arr = elements.Trim().Split(' ').Select(x => int.Parse(x)).ToArray();

            foreach (var c in arr)
            {
                if(c == 0)
                {
                    validString = false;
                }
            }

            while (!validString)
            {
                Console.WriteLine("Ivalid input. Element can't be equal 0. Try again:");
                elements = Console.ReadLine();
                arr = elements.Trim().Split(' ').Select(x => int.Parse(x)).ToArray();

                foreach (var c in arr)
                {
                    if(c == 0)
                    {
                        validString = false;
                        break;
                    }
                }
                validString = true;
            }

            Console.WriteLine("Output:");
            int count = 0;
            for (i = 0; i < arrSize; i++)
            {
                if ((arr[i] > 0 && arr[i+1] > 0)||(arr[i] < 0 && arr[i + 1] < 0))
                {
                    count++;
                    break;
                }
            }

            if(count != 0)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }

            Console.ReadLine();
        }

        static void task6()
        {
            Console.WriteLine("Write array size:");
            int arrSize = Convert.ToInt32(Console.ReadLine());

            while (arrSize < 1 || arrSize > 100)
            {
                Console.WriteLine("Incorrect value! Array size must be from 1 to 100. Try again:");
                arrSize = Convert.ToInt32(Console.ReadLine());
            }

            int[] arr = new int[arrSize];
            int i = 0;

            Console.WriteLine("Input array elements (use 1 string and space):");
            string elements = Console.ReadLine();

            arr = elements.Trim().Split(' ').Select(x => int.Parse(x)).ToArray();

            Console.WriteLine("Output:");
            int count = 0;
            for (i = 1; i < arrSize-1; i++) 
            {                                
                if (arr[i] > arr[i-1] && arr[i] > arr[i+1])
                {
                    count++;
                }
            }

            Console.WriteLine(count);

            Console.ReadLine();
        }

        static void task7()
        {
            Console.WriteLine("Write array size:");
            int arrSize = Convert.ToInt32(Console.ReadLine());

            while (arrSize < 1 || arrSize > 35)
            {
                Console.WriteLine("Incorrect value! Array size must be from 1 to 35. Try again:");
                arrSize = Convert.ToInt32(Console.ReadLine());
            }

            int[] arr = new int[arrSize];
            int i = 0;

            Console.WriteLine("Input array elements (use 1 string and space):");
            string elements = Console.ReadLine();

            arr = elements.Trim().Split(' ').Select(x => int.Parse(x)).ToArray();

            Console.WriteLine("Output:");
            int tmp = 0;
            arrSize--;
            for (i = 0; i <= arrSize/2; i++)
            {
                tmp = arr[arrSize-i];
                arr[arrSize-i] = arr[i];
                arr[i] = tmp;
            }

            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();

            Console.ReadLine();
        }

        static void task8()
        {
            Console.WriteLine("Write array size:");
            int arrSize = Convert.ToInt32(Console.ReadLine());

            while (arrSize < 1 || arrSize > 35)
            {
                Console.WriteLine("Incorrect value! Array size must be from 1 to 35. Try again:");
                arrSize = Convert.ToInt32(Console.ReadLine());
            }

            int[] arr = new int[arrSize];
            int i = 0;

            Console.WriteLine("Input array elements (use 1 string and space):");
            string elements = Console.ReadLine();

            arr = elements.Trim().Split(' ').Select(x => int.Parse(x)).ToArray();

            Console.WriteLine("Output:");
            int tmp = 0;
            for (i = 1; i < arrSize; i+=2)
            {
                tmp = arr[i-1];
                arr[i-1] = arr[i];
                arr[i] = tmp;
            }

            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();
            Console.ReadLine();
        }

        static void task9()
        {
            Console.WriteLine("Write array size:");
            int arrSize = Convert.ToInt32(Console.ReadLine());

            while (arrSize < 1 || arrSize > 35)
            {
                Console.WriteLine("Incorrect value! Array size must be from 1 to 35. Try again:");
                arrSize = Convert.ToInt32(Console.ReadLine());
            }

            int[] arr = new int[arrSize];
            int i = 0;

            Console.WriteLine("Input array elements (use 1 string and space):");
            string elements = Console.ReadLine();

            arr = elements.Trim().Split(' ').Select(x => int.Parse(x)).ToArray();

            Console.WriteLine("Output:");
            int tmp = 0;
            for (i = arrSize-1; i > 0; i--)
            {
                tmp = arr[i - 1];
                arr[i - 1] = arr[i];
                arr[i] = tmp;
            }

            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();
            Console.ReadLine();
        }

        static void task10()
        {
            Console.WriteLine("Write array size:");
            int arrSize = Convert.ToInt32(Console.ReadLine());

            while (arrSize < 1 || arrSize > 35)
            {
                Console.WriteLine("Incorrect value! Array size must be from 1 to 35. Try again:");
                arrSize = Convert.ToInt32(Console.ReadLine());
            }

            int[] arr = new int[arrSize];

            Console.WriteLine("Input array elements (use 1 string and space):");
            string elements = Console.ReadLine();

            arr = elements.Trim().Split(' ').Select(x => int.Parse(x)).ToArray();

            Console.WriteLine("Output:");
            int maxValue = -999;
            for (int i = 0; i < arrSize; i++)
            {
                if (maxValue < arr[i])
                {
                    maxValue = arr[i];
                }
            }

            Console.WriteLine(maxValue);
            Console.ReadLine();
        }

        static void task11()
        {
            Console.WriteLine("Write array size:");
            int arrSize = Convert.ToInt32(Console.ReadLine());

            while (arrSize < 1 || arrSize > 100)
            {
                Console.WriteLine("Incorrect value! Array size must be from 1 to 100. Try again:");
                arrSize = Convert.ToInt32(Console.ReadLine());
            }

            int[] arr = new int[arrSize];
            Boolean validString = true;

            Console.WriteLine("Input array elements (use 1 string and space). Next element must be bigger than previous:");
            string elements = Console.ReadLine();

            arr = elements.Trim().Split(' ').Select(x => int.Parse(x)).ToArray();

            for(int x=1;x <arrSize; x++)
            {
                if (arr[x] < arr[x-1])
                {
                    validString = false;
                }
            }

            while (!validString)
            {
                Console.WriteLine("Ivalid input. Next element must be bigger than previous. Try again:");
                elements = Console.ReadLine();
                arr = elements.Trim().Split(' ').Select(x => int.Parse(x)).ToArray();

                for (int x = 1; x < arrSize; x++)
                {
                    if (arr[x] < arr[x - 1])
                    {
                        validString = false;
                    }
                }
                validString = true;
            }

            Console.WriteLine("Output:");
            List<int> arr2 = new List<int>();
            for (int i = 0; i < arrSize; i++)
            {
                if (!arr2.Contains(arr[i]))
                {
                    arr2.Add(arr[i]);
                }
            }

            Console.WriteLine(arr2.Count());
            Console.ReadLine();
        }
    }
}
