using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;

namespace Sorting_Algorithms_Visualizer
{
    internal class Bubble : SortingLogic
    {
        // Initialize required variables
        private int[] arr;
        private Graphics g;
        private int y_max;

        public Bubble(int[] arr_i, Graphics g_i, int y_max_i)
        {
            arr = arr_i;
            g = g_i;
            y_max = y_max_i;
        }

        // Running the algorithm
        public void adjacent()
        {
<<<<<<< HEAD
            // Looping and swapping when needed         
            for (int i = 0; i < arr.Count()-1; i++)
            {
                if (arr[i] > arr[i + 1])
                {
                    sort(i, i + 1);
                }
            }
=======
                for (int i = 0; i < arr.Count()-1; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        sort(i, i + 1);
                    }
                }
>>>>>>> 7d7aa134e67997e011abf25ff856162ec6ef1796
        }

        // swap values
        private void sort(int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[i + 1];
            arr[i + 1] = temp;

            g.FillRectangle(new System.Drawing.SolidBrush(System.Drawing.Color.Black), i, 0, 1, y_max);
            g.FillRectangle(new System.Drawing.SolidBrush(System.Drawing.Color.Black), j, 0, 1, y_max);

            g.FillRectangle(new System.Drawing.SolidBrush(System.Drawing.Color.White), i, y_max - arr[i], 1, y_max);
            g.FillRectangle(new System.Drawing.SolidBrush(System.Drawing.Color.White), j, y_max - arr[j], 1, y_max);
        }

        // Loop through the array to verify if sorted
        public bool isSorted()
        {
            for (int i = 0; i < arr.Count()-1; i++)
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
