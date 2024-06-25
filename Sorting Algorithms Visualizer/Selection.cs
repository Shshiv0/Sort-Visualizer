using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Drawing.Text;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_Algorithms_Visualizer
{
    internal class Selection : SortingLogic
    {
        // Initialize required variables
        private int[] arr;
        private Graphics g;
        private int y_max;

        public Selection(int[] arr_i, Graphics g_i, int y_max_i)
        {
            arr = arr_i;
            g = g_i;
            y_max = y_max_i;
        }

        // Running the algorithm
        public void adjacent()
        {
            int j;
            int min;

            // Loop through array set min value
            for (int i = 0; i < arr.Length - 1; i++)
            {
                min = i;

                // loop and check conditional
                for (j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[min])
                    {
                        min = j;
                    }
                }
                addColor();
                if (min != i)
                {
                    swap(i, min);
                }
            }
        }

        // Swap values
        private void swap(int i, int j)
        {
            int temp = arr[j];
            arr[j] = arr[i];
            arr[i] = temp;

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
