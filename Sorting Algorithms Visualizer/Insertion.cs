using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Drawing.Text;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_Algorithms_Visualizer
{
    internal class Insertion : SortingLogic
    {
        // Initialize required variables
        private int[] arr;
        private Graphics g;
        private int y_max;

        public Insertion(int[] arr_i, Graphics g_i, int y_max_i)
        {
            arr = arr_i;
            g = g_i;
            y_max = y_max_i;
        }

        // Running the algorithm
        public void adjacent()
        {
            int j;
            int key;

            // Loop through array, setting key values and swapping when conditions are met
            for (int i = 1; i < arr.Length; i++)
            {
                key = arr[i];
                j = i - 1;
                
                while (j >= 0 && arr[j] > key)
                {
                    swap(j + 1, j);
                    j--;
                }
                arr[j + 1] = key;
            }
        }

        // Swap values
        private void swap(int i, int j)
        {
            arr[i] = arr[j];

            g.FillRectangle(new System.Drawing.SolidBrush(System.Drawing.Color.Black), i, 0, 1, y_max);
            g.FillRectangle(new System.Drawing.SolidBrush(System.Drawing.Color.Black), j, 0, 1, y_max);

            g.FillRectangle(new System.Drawing.SolidBrush(System.Drawing.Color.White), i, y_max - arr[i], 1, y_max);
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
