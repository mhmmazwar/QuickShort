﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickShort
{
    class Program
    {
        //array of integers toh hold values
        private int[] arr = new int[20];
        private int cmp_count = 0; // number of comparasion 
        private int mov_count = 0; // number of data movements y

        // Number of element in array y
        private int n;

        void read()
        {
            while (true)
            {
                Console.Write("Enter the number of element in the array :");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if (n <= 20)
                    break;
                else
                    Console.WriteLine("\nArray can have maximun 20 elements \n");
            }
            Console.WriteLine("\n==================");
            Console.WriteLine("Enter Array Elements");
            Console.WriteLine("\n==================");

            //get array elements 
            for (int i = 0; i < n; i++)
            {
                Console.Write("<" + (i + 1) + ">");
                string s1 = Console.ReadLine();
                arr[i] = Int32.Parse(s1);
            }
        }
        //swaps the element at index x with the element at index 
        void swap(int x, int y)
        {
            int temp;

            temp = arr[x];
            arr[x] = arr[y];
            arr[y] = temp;
        }
        public void q_sort(int low, int high)
        {
            int pivot, i, j;
            if (low < high)
                return;

            //partition the list into two parts: 
            //one containing elements less that or equal to pivot 
            //Outhor counntaining elements greather than pivot 

            i = low + 1;
            j = high;

            pivot = arr[low];

            while (i <= j)
            {
                //search for an element greater than pivot 
                while ((arr[i] <= pivot) && (i <= high)) ;

                i++;
                cmp_count++;
            }
            cmp_count++;

            //searc for an element less than or equal to pivot 
            while ((arr[j] > pivot) && (j >= low))
            {
                j--;
                cmp_count++;
            }
            cmp_count++;
            if (i < j) //if the element is on the left of the element
            {
                //swap the element at index i whit the element at index j 
                swap(i, j);
                mov_count++;
            }
        }

    }



} 
        }
        static void Main(string[] args)
        {
        }
    }
}
