using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_Algorithms_Visualizer
{
    internal interface SortingLogic
    {
        void adjacent();
        bool isSorted();
        void addColor();
    }
}
