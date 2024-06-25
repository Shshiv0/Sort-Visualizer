using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace Sorting_Algorithms_Visualizer
{
    internal class Heap : SortingLogic
    {
        // Initialize required variables
        private int[] arr;
        private Graphics g;
        private int y_max;

        public Heap(int[] arr_i, Graphics g_i, int y_max_i)
        {
            arr = arr_i;
            g = g_i;
            y_max = y_max_i;
        }

        // Running the algorithm
        public void adjacent()
        {
            sort(arr);
        }

        // Sort the values
        private void sort(int[] arr)
        {
           for (int i = arr.Length/2-1; i>=0; i--)
            {
                heapify(arr, arr.Length, i);
            }

            for (int i = arr.Length - 1; i>= 0; i--)
            {
                swap(arr, 0, i);
                heapify(arr, i, 0);
            }
        }

        // Heapify the array
        private void heapify(int[] arr, int n, int i)
        {
            int largest = i;
            int l = 2 * i + 1;
            int r = 2 * i + 2;

<<<<<<< HEAD
            // Check conditionals
=======
>>>>>>> 7d7aa134e67997e011abf25ff856162ec6ef1796
            if (l < n && arr[l] > arr[largest])
                largest = l;
            if (r < n && arr[r] > arr[largest])
                largest = r;

<<<<<<< HEAD
            // Swapping and recursion 
=======
>>>>>>> 7d7aa134e67997e011abf25ff856162ec6ef1796
            if (largest != i)
            {
                swap(arr, i, largest);
                heapify(arr, n, largest);
            }
        }

        // Swap values
        private void swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;

            g.FillRectangle(new System.Drawing.SolidBrush(System.Drawing.Color.Black), i, 0, 1, y_max);
            g.FillRectangle(new System.Drawing.SolidBrush(System.Drawing.Color.White), i, y_max - arr[i], 1, y_max);

            g.FillRectangle(new System.Drawing.SolidBrush(System.Drawing.Color.Black), j, 0, 1, y_max);
            g.FillRectangle(new System.Drawing.SolidBrush(System.Drawing.Color.White), j, y_max - arr[j], 1, y_max);
        }

        // Loop through the array to verify if sorted
        public bool isSorted()
        {
            for (int i = 0; i < arr.Count() - 1; i++)
            {
                if (arr[i] > arr[i + 1])
                {
                    return false;
                }
            }
            return true;
        }

        public void addColor()
        {
            for (int i = 0; i < arr.Count() - 1; i++)
            {
                g.FillRectangle(new System.Drawing.SolidBrush(System.Drawing.Color.White), i, y_max - arr[i], 1, y_max);
            }
        }
    }
}
