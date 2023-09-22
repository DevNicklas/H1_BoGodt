using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static H1_BoGodt.Model.window.Window;

namespace H1_BoGodt.Model.window
{
    /// <summary>
    /// Class <see cref="TwoBayWindow"/> represents a window with a double bay
    /// </summary>
    internal class TwoBayWindow : Window
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TwoBayWindow"/> class, using multiple arguments
        /// </summary>
        /// <param name="windowSupplier">window supplier</param>
        internal TwoBayWindow(EWindowSupplier windowSupplier)
        {
            Supplier = windowSupplier;
            Price = 2798;
            // Adds 25% to the price if the supplier is Vindbjerg
            if (windowSupplier == EWindowSupplier.Vindbjerg)
            {
                Price *= 1.25;
            }
        }
    }
}
