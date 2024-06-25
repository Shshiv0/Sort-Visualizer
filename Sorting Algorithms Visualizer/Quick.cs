using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Sorting_Algorithms_Visualizer
{
    internal class Quick : SortingLogic
    {
        // Initialize required variables
        private int[] arr;
        private Graphics g;
        private int y_max;

        public Quick(int[] arr_i, Graphics g_i, int y_max_i)
        {
            arr = arr_i;
            g = g_i;
            y_max = y_max_i;
        }

        // Running the algorithm
        public void adjacent()
        {
            int low = 0;
            int high = arr.Length - 1;
            sort(arr, 0, high);
     
        }

        // Partition array into smaller sub-arrays
        private int partition(int[] arr, int low, int high)
        {
<<<<<<< HEAD
            // Set pivot variable
            int pivot = arr[high];
            int i = (low - 1);

            // looping through and checking if index is less than pivot value
=======
            int pivot = arr[high];
            int i = (low - 1);

>>>>>>> 7d7aa134e67997e011abf25ff856162ec6ef1796
            for (int j = low; j <= high - 1; j++)
            {
                if (arr[j] < pivot)
                {
                    i++;
                    swap(arr, i, j);
                }
            }
            swap(arr, i + 1, high);
            return (i + 1);
        }

        // Sort the values
        private void sort(int[] arr, int low, int high)
        {
            if(low < high)
            {
                int p = partition(arr, low, high);

                sort(arr, low, p - 1);
                sort(arr, p + 1, high);
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